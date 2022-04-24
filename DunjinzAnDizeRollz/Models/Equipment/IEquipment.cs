using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models
{
    public interface IEquipment
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public EquipmentType Type { get; set; }
    }

    public enum EquipmentType
    {
        Weapon,
        Armour,
        Potion
    }
}
