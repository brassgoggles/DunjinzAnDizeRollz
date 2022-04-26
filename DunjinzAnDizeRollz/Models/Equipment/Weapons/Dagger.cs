using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.Equipment.Weapons
{
    public class Dagger : IWeapon
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
        public Dagger()
        {
            Name = "Dagger";
            Weight = 3;
            Type = EquipmentType.Weapon;
            HitPointBonus = 0;
            DefenceBonus = 0;
            MinDamageBonus = 1;
            MaxDamageBonus = 5;
            DamageReductionBonus = 0;
            NumberOfMeleeAttacksBonus = 3;
            InitiativeBonus = 10;
            WeightCapacityBonus = 0;
        }
    }
}
