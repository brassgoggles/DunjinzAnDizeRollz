using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models
{
    public interface IWeapon : IEquipment
    {
        public new string Name { get; set; }
        public new int Weight { get; set; }
        public new EquipmentType Type { get => EquipmentType.Weapon; }

        public int NumberOfAttacks { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        //public IWeapon(string name,
        //    int weight,
        //    int numberOfAttacks,
        //    int minDamage,
        //    int maxDamage)
        //{
        //    Name = name;
        //    Weight = weight;
        //    NumberOfAttacks = numberOfAttacks;
        //    MinDamage = minDamage;
        //    MaxDamage = maxDamage;
        //}
    }
}
