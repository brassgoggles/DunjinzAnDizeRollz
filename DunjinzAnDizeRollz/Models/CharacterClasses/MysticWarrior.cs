using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.CharacterClasses
{
    public class MysticWarrior : ICharacterClass
    {
        public string Name { get; set; }
        public int HitPointBonus { get; set; }
        public int DefenceBonus { get; set; }
        public int DamageBonus { get; set; }
        public int DamageReductionBonus { get; set; }
        public int NumberOfAttacksBonus { get; set; }
        public int InitiativeBonus { get; set; }
        public int WeightCapacity { get; set; }

        public MysticWarrior()
        {
            Name = "Mystic Warrior";
            HitPointBonus = 0;
            DefenceBonus = 0;
            DamageReductionBonus = 0;
            NumberOfAttacksBonus = 0;
            WeightCapacity = 100;
        }
    }
}
