using DunjinzAnDizeRollz.Models;
using DunjinzAnDizeRollz.Models.CharacterClasses;
using DunjinzAnDizeRollz.Models.Races;
using DunjinzAnDizeRollz.Models.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Scenes
{
    public static class MainMenu
    {
        public static bool InitiateMainMenu()
        {
            Program.GameController = GameState.MainMenu;

            List<Option> menuOptions = new List<Option>()
            {
                new Option("Choose next opponent", () => { ChooseOpponentMenu.InitiateMenu(); return null; }),
                new Option("Exit", () => { Environment.Exit(0); return false; })
            };

            Menu mainMenu = new("MAIN MENU", menuOptions);

            return false;
        }
    }
}
