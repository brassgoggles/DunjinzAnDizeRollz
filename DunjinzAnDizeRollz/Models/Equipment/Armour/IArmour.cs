using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models
{
    public interface IArmour : IEquipment
    {        
        public new string Name { get; set; }
        public new int Weight { get; set; }
        public new EquipmentType Type { get => EquipmentType.Armour; }

        public int ArmourBonus { get; set; }
        public int DamageReduction { get; set; }
    }
}
