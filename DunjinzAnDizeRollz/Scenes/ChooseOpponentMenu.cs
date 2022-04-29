using DunjinzAnDizeRollz.Models;
using DunjinzAnDizeRollz.Models.CharacterClasses;
using DunjinzAnDizeRollz.Models.Races;
using DunjinzAnDizeRollz.Models.Unit;
using DunjinzAnDizeRollz.Models.Units;
using DunjinzAnDizeRollz.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Scenes
{
    public static class ChooseOpponentMenu
    {
        public static void InitiateMenu()
        {
            Program.GameController = GameState.CombatMenu;

            List<Option> menuOptions = new List<Option>();

            foreach (var npc in NPCBuilder.NPCList())
            {
                menuOptions.Add(new Option(npc.Name, () =>
                {
                    new Combat(npc);
                    return null;
                }));
            }

            menuOptions.Add(new Option("Exit", () => { 
                Program.GameController = GameState.MainMenu; return  null; 
            }));

            while (Program.GameController == GameState.CombatMenu)
            {
                Menu mainMenu = new("CHOOSE OPPONENT", menuOptions); 
            }
        }    
    }
}
