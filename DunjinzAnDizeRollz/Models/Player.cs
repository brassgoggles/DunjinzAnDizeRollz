using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DunjinzAnDizeRollz.Models.Creature;
using DunjinzAnDizeRollz.Resources;

namespace DunjinzAnDizeRollz.Models
{
    public class Player : BasePropertyChanged, ICreature
    {
        public string Name { get; set; }

        private ICharacterClass characterClass;

        public ICharacterClass CharacterClass
        {
            get => characterClass;

            set
            {
                SetProperty(ref characterClass, value);

                // TODO: Add all bonuses for that particular CharacterClass
                if(characterClass != null)
                {
                    TotalHitPoints += characterClass.HitPointBonus;
                    DefenceBonus += characterClass.DefenceBonus;
                    DamageReduction += characterClass.DamageReductionBonus;
                    NumberOfAttacks += characterClass.NumberOfAttacksBonus;
                    InitiativeBonus += characterClass.InitiativeBonus;
                    WeightCapacity += characterClass.WeightCapacityBonus;
                }
            }
        }

        public int Experience { get; set; }
        public int Level { get; set; }

        public int TotalHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int DefenceBonus { get; set; }
        public int DamageBonus { get; set; }
        public int DamageReduction { get; set; }
        public int NumberOfAttacks { get; set; }
        // TODO: Add up initiative from class and any other items or abilities that may increase initiative.
        public int InitiativeBonus { get; set; }
        public int WeightCapacity { get; set; }

        private IWeapon weaponSlot;

        public IWeapon WeaponSlot 
        { 
            get => weaponSlot; set
            {
                SetProperty(ref weaponSlot, value);

                if (weaponSlot != null)
                {
                    MinDamage += weaponSlot.MinDamage;
                    MaxDamage += weaponSlot.MaxDamage;
                }
            }
        }

        private IArmour armour;

        public IArmour Armour 
        { 
            get => armour;
            set
            {
                SetProperty(ref armour, value);

                if (armour != null)
                    DefenceBonus += armour.ArmourBonus;
            } 
        }
        public int Gold { get; set; }

        public Player()
        {
            Experience = 0;
            Level = 1;
            TotalHitPoints = 100;
            Gold = 0;
        }

        // An instantiation of the player currently used for testing.
        public Player(ICharacterClass characterClass, IWeapon weapon, IArmour armour)
        {
            Name = "Player1";
            Experience = 0;
            Level = 1;
            TotalHitPoints = 100;
            Gold = 0;
            CharacterClass = characterClass;
            WeaponSlot = weapon;
            Armour = armour;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Class: {CharacterClass}\n" +
                $"Experience: {Experience}\n" +
                $"Level: {Level}\n" +
                $"Hit Points: {TotalHitPoints}\n" +
                $"Weapon Slot 1: {WeaponSlot?.Name}\n" +
                $"Armour: {Armour?.Name}\n" +
                $"Gold: {Gold}\n\n";
        }
    }
}
