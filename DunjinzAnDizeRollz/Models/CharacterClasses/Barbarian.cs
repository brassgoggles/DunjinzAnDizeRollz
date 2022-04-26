using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.CharacterClasses
{
    public class Barbarian : BaseCharacterClass
    {
        public Barbarian()
        {
            ClassName = "Barbarian";
            HitPointBonus = 30;
            DefenceBonus = 10;
            MinDamageBonus = 0;
            MaxDamageBonus = 0;
            DamageReductionBonus = 20;
            NumberOfMeleeAttacksBonus = 1;
            InitiativeBonus = 0;
            WeightCapacityBonus = 40;
        }
    }
}
