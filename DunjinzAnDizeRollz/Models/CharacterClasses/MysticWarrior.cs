using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.CharacterClasses
{
    public class MysticWarrior : BaseCharacterClass
    {
        // TODO: Implement MysticWarrior abilities.
        public MysticWarrior()
        {
            ClassName = "Mystic Warrior";
            HitPointBonus = 0;
            DefenceBonus = 0;
            MinDamageBonus = 0;
            MaxDamageBonus = 0;
            DamageReductionBonus = 0;
            NumberOfMeleeAttacksBonus = 0;
            InitiativeBonus = 10;
            WeightCapacityBonus = 0;
        }
    }
}
