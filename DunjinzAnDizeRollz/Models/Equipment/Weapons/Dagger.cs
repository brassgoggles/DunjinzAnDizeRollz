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

        public int NumberOfAttacks { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public Dagger()
        {
            Name = "Dagger";
            Weight = 2;
            NumberOfAttacks = 2;
            MinDamage = 1;
            MaxDamage = 5;
        }
    }
}
