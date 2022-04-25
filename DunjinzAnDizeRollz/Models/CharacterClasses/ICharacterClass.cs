using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models
{
    public interface ICharacterClass
    {    
        public string Name { get; set; }
        public int HitPointBonus { get; set; }
        public int DefenceBonus { get; set; }
        public int DamageBonus { get; set; }
        public int DamageReductionBonus { get; set; }
        public int NumberOfAttacksBonus { get; set; }
        public int InitiativeBonus { get; set; }
        public int WeightCapacityBonus { get; set; }
    }
}
