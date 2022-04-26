using DunjinzAnDizeRollz.Models;
using DunjinzAnDizeRollz.Models.CharacterClasses;
using DunjinzAnDizeRollz.Models.Equipment;
using DunjinzAnDizeRollz.Models.Equipment.Armour;
using DunjinzAnDizeRollz.Models.Equipment.Weapons;
using DunjinzAnDizeRollz.Models.Races;
using DunjinzAnDizeRollz.Models.Units;
using DunjinzAnDizeRollz.Resources;
using System;
using System.Collections.Generic;

namespace DunjinzAnDizeRollz
{
    class Program
    {
        //static Player player = new Player(new Barbarian(), new BattleAxe(), new Rags());

        static Player player = new Player("Player1", new Human(), new Barbarian(), 0, 0,
            baseNumberOfMeleeAttacks: 1, weaponSlot: new BattleAxe());

        static void Main(string[] args)
        {

            //Intro();

            Combat(new GoblinWretch(new Goblin(), new Barbarian(), baseHitPoints: 100));

            Console.ReadKey();
        }

        #region Intro and character creation
        private static void Intro()
        {
            Console.WriteLine("You awake to find yourself caged in a holding room just outside " +
                "of an arena.\n\n" +
                "A hand swiftly slaps across your face. A guard standing over you having a\n" +
                "chuckle with his fellow guard. 'You awake yet? You better be, you're \n" +
                "fighting next.' The other guard laughing at your situation.\n\n" +
                "Come on then, what are we going to call you?");

            Console.WriteLine("In a some what dazed response you reply, 'My name is...'");
            player.Name = Console.ReadLine();

            Console.WriteLine($"\n\nRighto {player.Name}, you're going to need something to \n" +
                $"fight with. What's your style?\n\n");

            player.CharacterClass = SelectClass();

            EquipPlayer();

            Console.WriteLine("The guard smirks a little, 'Alright, time to get in there " +
                "and fight... or die, I don't care.\n\n" +
                "The gate to the arena clatters as it opens upwards. The guards push you " +
                "through and into the bright light of the open arena. The crowd jeers " +
                "as you stand before your opponent.\n\n");
        }

        private static BaseCharacterClass SelectClass()
        {
            Console.WriteLine("[Press a number to select from the following]\n" +
                "1 - [Barbarian] I see an enemy, I hit an enemy!\n" +
                "2 - [Duelist] I like to think I have some sort of finesse.\n" +
                "3 - [Mystic Warrior] I manipulate the power of the void.\n\n");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    return new Barbarian();
                case "2":
                    return new Duelist();
                case "3":
                    return new MysticWarrior();
                default:
                    return SelectClass();
            }
        }

        private static void EquipPlayer()
        {
            Console.WriteLine("I see. Well we want it to be a good show so we're going to \n" +
                "suit you up... a little.\n\n");

            switch (player.CharacterClass)
            {
                case Barbarian:
                    player.WeaponSlot = new BattleAxe();
                    break;
                case Duelist:
                    player.WeaponSlot = new Rapier();
                    break;
                case MysticWarrior:
                    player.WeaponSlot = new Longsword();
                    break;
            }

            Console.WriteLine($"Equipment aquired - {player.WeaponSlot.Name}");
            Console.WriteLine($"Equipment equipped - {player.WeaponSlot.Name}");

            player.Armour = new Rags();
            Console.WriteLine($"Equipment aquired - {player.Armour.Name}");
            Console.WriteLine($"Equipment equipped - {player.Armour.Name}");
        }
        #endregion

        #region Combat
        public static bool continueCombat = true;

        private static void Combat(BaseUnit opponent)
        {
            Console.WriteLine($"Before you stands a {opponent.Name}!\n\n");

            int i = 1;

            while (continueCombat)
            {
                Console.WriteLine($"*************** Round {i} ***************");
                Console.WriteLine("***** Roll for initiative *****");
                List<BaseUnit> attackQueue = Initiative(opponent);
                CommonFunctions.ProceedStory();

                foreach (var unit in attackQueue)
                {
                    continueCombat = unit.Tag == "player" ? unit.ActionTurn(player) : unit.ActionTurn(opponent);
                }
                i++;
            }
        }

        public static Random random = new Random();

        private static List<BaseUnit> Initiative(BaseUnit opponent)
        {
            int opponentRoll = random.Next(1, 101) + opponent.TotalInitiative;
            int playerRoll = random.Next(1, 101) + player.TotalInitiative;

            Console.WriteLine($"Opponent initiative: {opponentRoll}");
            Console.WriteLine($"Player initiative: {playerRoll}\n\n");

            if (playerRoll > opponentRoll)
            {
                // Player goes first.
                return new List<BaseUnit>()
                {
                    player,
                    opponent
                };
            }
            else if (playerRoll < opponentRoll)
            {
                // Opponent goes first.
                return new List<BaseUnit>()
                {
                    opponent,
                    player
                };
            }
            else
            {
                // Both have same initiative, trigger reroll.
                return Initiative(opponent);
            }
        }
        #endregion
    }
}
