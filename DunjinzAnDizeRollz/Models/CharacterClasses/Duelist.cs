using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.CharacterClasses
{
    public class Duelist : ICharacterClass
    {
        public string Name { get; set; }
        public int HitPointBonus { get; set; }
        public int DefenceBonus { get; set; }
        public int DamageBonus { get; set; }
        public int DamageReductionBonus { get; set; }
        public int NumberOfAttacksBonus { get; set; }
        public int InitiativeBonus { get; set; }
        public int WeightCapacityBonus { get; set; }

        public Duelist()
        {
            Name = "Duelist";
            HitPointBonus = 15;
            DefenceBonus = 5;
            DamageReductionBonus = 5;
            NumberOfAttacksBonus = 2;
            InitiativeBonus = 5;
            WeightCapacityBonus = 120;
        }
    }
}
