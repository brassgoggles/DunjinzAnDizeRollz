using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DunjinzAnDizeRollz.Models.CharacterClasses;
using DunjinzAnDizeRollz.Models.Equipment.Armour;
using DunjinzAnDizeRollz.Models.Equipment.Weapons;
using DunjinzAnDizeRollz.Models.Races;
using DunjinzAnDizeRollz.Models.Units;
using DunjinzAnDizeRollz.Resources;

namespace DunjinzAnDizeRollz.Models
{
    public class Player : BaseUnit
    {
        public int Experience { get; set; }
        public int Gold { get; set; }

        public Player(
                    string name,
                    BaseRace race,
                    BaseCharacterClass characterClass,
                    int experience,
                    int gold,
                    string tag = "player",
                    int level = 1,
                    int baseHitPoints = 100,
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
            Name = name;
            Tag = tag;
            Race = race;
            Experience = experience;
            Gold = gold;
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

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Class: {CharacterClass}\n" +
                $"Experience: {Experience}\n" +
                $"Level: {Level}\n" +
                $"Hit Points: {BaseHitPoints}\n" +
                $"Weapon Slot 1: {WeaponSlot?.Name}\n" +
                $"Armour: {Armour?.Name}\n" +
                $"Gold: {Gold}\n\n";
        }
    }
}
