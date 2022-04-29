using DunjinzAnDizeRollz.Models;
using DunjinzAnDizeRollz.Models.CharacterClasses;
using DunjinzAnDizeRollz.Models.Equipment;
using DunjinzAnDizeRollz.Models.Equipment.Armour;
using DunjinzAnDizeRollz.Models.Equipment.Weapons;
using DunjinzAnDizeRollz.Models.Races;
using DunjinzAnDizeRollz.Models.Units;
using DunjinzAnDizeRollz.Resources;
using DunjinzAnDizeRollz.Scenes;
using System;
using System.Collections.Generic;

namespace DunjinzAnDizeRollz
{
    class Program
    {
        public static Player player = new Player("Player1", new Human(), new Duelist(), 0, 0,
            baseNumberOfMeleeAttacks: 1, weaponSlot: new BattleAxe());

        static void Main(string[] args)
        {
            //Intro();
            MainMenu.InitiateMainMenu();
            Console.ReadKey();
        }
    }
}
