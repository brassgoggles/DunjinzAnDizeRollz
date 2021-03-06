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
        public int NPCRank { get; set; }

        public GoblinWretch(
                        BaseCharacterClass characterClass = null,
                        int experienceValue = 20,
                        int rewardLevel = 1,
                        string name = "Goblin Wretch",
                        string tag = "npc",
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
                        IArmour armour = null)
        {
            Race = new Goblin();
            NPCRank = 2;

            Tag = tag;
            Level = level;
            CharacterClass = characterClass == null ? new BaseCharacterClass() : characterClass;
            Name = $"LVL {Level} {name} {CharacterClass.ClassName}";
            ExperienceValue = experienceValue;
            RewardLevel = rewardLevel;
            BaseHitPoints = baseHitPoints + (NPCRank * Level);
            CurrentHitPoints = BaseHitPoints;
            BaseMinDamage = baseMinDamage + (NPCRank * Level);
            BaseMaxDamage = baseMaxDamage + (NPCRank * Level);
            BaseDefence = baseDefence + (NPCRank * Level);
            BaseDamageReduction = baseDamageReduction;
            BaseNumberOfMeleeAttacks = baseNumberOfMeleeAttacks;
            BaseInitiative = baseInitiative + (NPCRank * Level);
            BaseWeightCapacity = baseWeightCapacity;
            WeaponSlot = weaponSlot == null ? new Dagger() : weaponSlot;
            Armour = armour == null ? new Rags() : armour;
        }
    }
}
