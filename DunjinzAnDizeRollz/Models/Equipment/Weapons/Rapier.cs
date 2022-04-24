using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.Equipment.Weapons
{
    public class Rapier : IWeapon
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public EquipmentType Type { get; set; }

        public int NumberOfAttacks { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public Rapier()
        {
            Name = "Rapier";
            Weight = 5;
            NumberOfAttacks = 2;
            MinDamage = 3;
            MaxDamage = 6;
        }
    }
}
