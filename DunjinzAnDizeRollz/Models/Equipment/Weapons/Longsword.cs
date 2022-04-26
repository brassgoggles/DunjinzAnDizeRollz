using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.Equipment.Weapons
{
    public class Longsword : IWeapon
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public EquipmentType Type { get; set; }
        public int HitPointBonus { get; set; }
        public int DefenceBonus { get; set; }
        public int MinDamageBonus { get; set; }
        public int MaxDamageBonus { get; set; }
        public int DamageReductionBonus { get; set; }
        public int NumberOfMeleeAttacksBonus { get; set; }
        public int InitiativeBonus { get; set; }
        public int WeightCapacityBonus { get; set; }

        // Basic version of weapon.
        public Longsword()
        {
            Name = "Longsword";
            Weight = 15;
            Type = EquipmentType.Weapon;
            HitPointBonus = 0;
            DefenceBonus = 0;
            MinDamageBonus = 10;
            MaxDamageBonus = 15;
            DamageReductionBonus = 0;
            NumberOfMeleeAttacksBonus = 1;
            InitiativeBonus = 5;
            WeightCapacityBonus = 0;
        }
    }
}
