using DunjinzAnDizeRollz.Models;
using DunjinzAnDizeRollz.Models.CharacterClasses;
using DunjinzAnDizeRollz.Models.Creature;
using DunjinzAnDizeRollz.Models.Equipment;
using DunjinzAnDizeRollz.Models.Equipment.Armour;
using DunjinzAnDizeRollz.Models.Equipment.Weapons;
using System;
using System.Collections.Generic;

namespace DunjinzAnDizeRollz
{
    class Program
    {
        static Player player = new Player();

        static void Main(string[] args)
        {

            Intro();

            Combat(new Goblin());

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

        private static ICharacterClass SelectClass()
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

        private static void Combat(ICreature creature)
        {
            Console.WriteLine($"Before you stands a {creature.Name}!\n\n");

            PlayerMove(new Goblin());
        }

        public static Random random = new Random();

        private static void Initiative(ICreature creature)
        {
            Console.WriteLine("********** Roll for initiative **********");

            
            int creatureRoll = random.Next(1, 101) + creature.InitiativeBonus;
            int playerRoll = random.Next(1, 101) + player.TotalInitiativeBonus;

            Console.WriteLine($"Creature initiative: {creatureRoll}");
            Console.WriteLine($"Player initiative: {playerRoll}");
            

            // Player goes first by default.

            if(playerRoll < creatureRoll)
            {
                // Player goes second.
            }
            else if(playerRoll == creatureRoll)
            {
                // Trigger reroll
            }
        }

        private static void PlayerMove(ICreature creature)
        {
            int dmg = random.Next(player.WeaponSlot.MinDamage, player.WeaponSlot.MaxDamage + 1);
            creature.CurrentHitPoints -= dmg;
            Console.WriteLine($"Creatue HP: {creature.CurrentHitPoints}");
        }

        private static void CreatureMove(ICreature creature)
        {
            int dmg = random.Next(creature.WeaponSlot.MinDamage, creature.WeaponSlot.MaxDamage + 1);
            player.CurrentHitPoints -= dmg;
            Console.WriteLine($"Player HP: {player.CurrentHitPoints}");
        }
    }
}
