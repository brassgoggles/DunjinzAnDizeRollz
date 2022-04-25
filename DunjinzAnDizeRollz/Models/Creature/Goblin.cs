using DunjinzAnDizeRollz.Models.Equipment.Armour;
using DunjinzAnDizeRollz.Models.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.Creature
{
    public class Goblin : ICreature, INPC
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int TotalHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int DefenceBonus { get; set; }
        public int DamageBonus { get; set; }
        public int DamageReduction { get; set; }
        public int NumberOfAttacks { get; set; }
        public int InitiativeBonus { get; set; }
        public int WeightCapacity { get; set; }
        public IWeapon WeaponSlot { get; set; }
        public IArmour Armour { get; set; }

        public int ExperienceValue { get; set; }
        public int RewardLevel { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public Goblin()
        {
            Name = "Goblin";
            Level = 1;
            TotalHitPoints = 50;
            CurrentHitPoints = 50;
            WeaponSlot = new Dagger();
            Armour = new Rags();
            ExperienceValue = 10;
            RewardLevel = 1;
            DefenceBonus = 0;
            DamageBonus = 0;
            DamageReduction = 0;
            NumberOfAttacks = 1;
            InitiativeBonus = 3;
            WeightCapacity = 50;
        }
    }
}
