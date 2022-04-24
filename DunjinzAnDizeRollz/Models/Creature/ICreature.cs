﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.Creature
{
    public interface ICreature
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int TotalHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public IWeapon WeaponSlot { get; set; }
        public IArmour Armour { get; set; }
        public int ExperienceValue { get; set; }
        public int RewardLevel { get; set; }
        public int DefenceBonus { get; set; }
        public int DamageBonus { get; set; }
        public int DamageReduction { get; set; }
        public int NumberOfAttacks { get; set; }
        public int InitiativeBonus { get; set; }
        public int WeightCapacity { get; set; }
    }
}
