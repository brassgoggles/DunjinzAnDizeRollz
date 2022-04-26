using DunjinzAnDizeRollz.Models.CharacterClasses;
using DunjinzAnDizeRollz.Models.Equipment.Armour;
using DunjinzAnDizeRollz.Models.Equipment.Weapons;
using DunjinzAnDizeRollz.Models.Races;
using DunjinzAnDizeRollz.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.Units
{
    public class GoblinWretch :  BaseUnit, INPC
    {
        public int ExperienceValue { get; set; }
        public int RewardLevel { get; set; }

        public GoblinWretch(BaseRace race,
                            BaseCharacterClass characterClass,
                            string tag = "npc",
                            int experienceValue = 20,
                            int rewardLevel = 1,
                            string name = "Goblin Wretch",
                            int level = 1,
                        int baseHitPoints = 10,
                        int baseMinDamage = 1,
                        int baseMaxDamage = 1,
                        int baseDefence = 25,
                        int baseDamageReduction = 0,
                        int baseNumberOfMeleeAttacks = 1,
                        int baseInitiative = 0,
                        int baseWeightCapacity = 0,
                        IWeapon weaponSlot = null,
                        IArmour armour = null) :
            base(name, tag, race, characterClass)
        {
            Name = name;
            Tag = tag;
            Race = race;
            ExperienceValue = experienceValue;
            RewardLevel = rewardLevel;
            Level = level;
            BaseHitPoints = baseHitPoints;
            CurrentHitPoints = baseHitPoints;
            BaseMinDamage = baseMinDamage;
            BaseMaxDamage = baseMaxDamage;
            BaseDefence = baseDefence;
            BaseDamageReduction = baseDamageReduction;
            BaseNumberOfMeleeAttacks = baseNumberOfMeleeAttacks;
            BaseInitiative = baseInitiative;
            BaseWeightCapacity = baseWeightCapacity;
            WeaponSlot = weaponSlot;
            Armour = armour;
        }

        public override bool ActionTurn(BaseUnit opponent)
        {
            return MeleeAttack(opponent);
        }
    }
}
