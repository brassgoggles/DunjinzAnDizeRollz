using DunjinzAnDizeRollz.Models.CharacterClasses;
using DunjinzAnDizeRollz.Models.Races;
using DunjinzAnDizeRollz.Models.Unit;
using DunjinzAnDizeRollz.Models.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Resources
{
    public static class NPCBuilder
    {
        public static List<BaseUnit> NPCList()
        {
            return new List<BaseUnit>()
            {
                new GoblinWretch(),
                new OrcGrunt()
            };
        }
    }
}
