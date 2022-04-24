using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.Equipment
{
    public class BattleAxe : IWeapon
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public EquipmentType Type { get; set; }

        public int NumberOfAttacks { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }        

        public BattleAxe()
        {
            Name = "Battle Axe";
            Weight = 20;
            NumberOfAttacks = 1;
            MinDamage = 10;
            MaxDamage = 20;
        }
    }
}
