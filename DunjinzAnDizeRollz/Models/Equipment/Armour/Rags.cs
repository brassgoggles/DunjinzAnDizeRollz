using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.Equipment.Armour
{
    public class Rags : IArmour
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
        public Rags()
        {
            Name = "Rags";
            Weight = 5;
            Type = EquipmentType.Armour;
            HitPointBonus = 0;
            DefenceBonus = 5;
            MinDamageBonus = 0;
            MaxDamageBonus = 0;
            DamageReductionBonus = 1;
            NumberOfMeleeAttacksBonus = 0;
            InitiativeBonus = 0;
            WeightCapacityBonus = 0;
        }
    }
}
