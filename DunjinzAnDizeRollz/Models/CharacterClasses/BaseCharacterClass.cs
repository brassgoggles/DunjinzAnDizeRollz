using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.CharacterClasses
{
    public class BaseCharacterClass : ICharacteristicBonuses
    {    
        public string ClassName { get; set; }
        public int HitPointBonus { get; set; }
        public int DefenceBonus { get; set; }
        public int MinDamageBonus { get; set; }
        public int MaxDamageBonus { get; set; }
        public int DamageReductionBonus { get; set; }
        public int NumberOfMeleeAttacksBonus { get; set; }
        public int InitiativeBonus { get; set; }
        public int WeightCapacityBonus { get; set; }

        // Constructor can be used to generate basic NPC CharacterClass.
        public BaseCharacterClass() { ClassName = "BaseClass"; }
    }
}
