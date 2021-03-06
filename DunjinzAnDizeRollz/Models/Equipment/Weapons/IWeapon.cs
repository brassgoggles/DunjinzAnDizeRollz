using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.Equipment.Weapons
{
    public interface IWeapon : IEquipment, ICharacteristicBonuses
    {
        public new string Name { get; set; }
        public new int Weight { get; set; }
        public new EquipmentType Type { get => EquipmentType.Weapon; }
    }
}
