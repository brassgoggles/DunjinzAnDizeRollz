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
        public int ArmourBonus { get; set; }
        public int DamageReduction { get; set; }

        public Rags()
        {
            Name = "Rags";
            Weight = 5;
            ArmourBonus = 5;
            DamageReduction = 1;
        }
    }
}
