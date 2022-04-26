using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.CharacterClasses
{
    public class Duelist : BaseCharacterClass
    {
        public Duelist()
        {
            ClassName = "Duelist";
            HitPointBonus = 15;
            DefenceBonus = 5;
            MinDamageBonus = 0;
            MaxDamageBonus = 0;
            DamageReductionBonus = 5;
            NumberOfMeleeAttacksBonus = 2;
            InitiativeBonus = 30;
            WeightCapacityBonus = 15;
        }
    }
}
