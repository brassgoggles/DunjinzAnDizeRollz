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
        public static GameState GameController = GameState.MainMenu;

        // Base player mainly for testing, is overriden during Intro.
        public static Player player = new Player("Player1", new Human(),
            new Barbarian(), 0, 0, weaponSlot: new BattleAxe());

        static void Main(string[] args)
        {
            Intro.InitiateIntro();
            while (GameController != GameState.GameOver)
            {
                MainMenu.InitiateMainMenu(); 
            }

            Console.ReadKey();
        }
    }

    public enum GameState
    {
        MainMenu,
        CombatMenu,
        GameOver
    }
}
