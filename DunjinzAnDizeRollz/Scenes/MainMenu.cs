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
        public static void InitiateMainMenu()
        {
            List<Option> menuOptions = new List<Option>()
            {
                new Option("Choose next opponent", () => new Combat(new GoblinWretch(new Goblin(), new BaseCharacterClass(), baseHitPoints: 50))),
                new Option("Exit", () => { Environment.Exit(0); return null; })
            };

            Menu mainMenu = new("MAIN MENU", menuOptions);
        }
    }
}
