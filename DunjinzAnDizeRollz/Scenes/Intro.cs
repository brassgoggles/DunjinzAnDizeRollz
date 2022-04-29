using DunjinzAnDizeRollz.Models.CharacterClasses;
using DunjinzAnDizeRollz.Models.Equipment.Armour;
using DunjinzAnDizeRollz.Models.Equipment.Weapons;
using DunjinzAnDizeRollz.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Scenes
{
    public static class Intro
    {
        public static void InitiateIntro()
        {
            Console.WriteLine("You awake to find yourself caged in a holding room just outside " +
                "of an arena.\n\n" +
                "A hand swiftly slaps across your face. A guard standing over you having a\n" +
                "chuckle with his fellow guard. 'You awake yet? You better be, you're \n" +
                "fighting next.' The other guard laughing at your situation.\n\n" +
                "Come on then, what are we going to call you?");

            Console.WriteLine("In a some what dazed response you reply, 'My name is...'");
            Program.player.Name = Console.ReadLine();

            Console.WriteLine($"\n\nRighto {Program.player.Name}, you're going to need something to \n" +
                $"fight with. What's your style?\n\n");

            Program.player.CharacterClass = SelectClass();

            EquipPlayer();

            Console.WriteLine("The guard smirks a little, 'Alright, time to get in there \n" +
                "and fight... or die, I don't care.\n\n" +
                "The gate to the arena clatters as it opens upwards. The guards push you \n" +
                "through and into the bright light of the open arena. The crowd jeers \n" +
                "as you stand before your opponent.\n\n");

            CommonFunctions.ProceedStory();
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

            switch (Program.player.CharacterClass)
            {
                case Barbarian:
                    Program.player.WeaponSlot = new BattleAxe();
                    break;
                case Duelist:
                    Program.player.WeaponSlot = new Rapier();
                    break;
                case MysticWarrior:
                    Program.player.WeaponSlot = new Longsword();
                    break;
            }

            Console.WriteLine($"Equipment aquired - {Program.player.WeaponSlot.Name}");
            Console.WriteLine($"Equipment equipped - {Program.player.WeaponSlot.Name}");

            Program.player.Armour = new Rags();
            Console.WriteLine($"Equipment aquired - {Program.player.Armour.Name}");
            Console.WriteLine($"Equipment equipped - {Program.player.Armour.Name}");
        }
    }
}
