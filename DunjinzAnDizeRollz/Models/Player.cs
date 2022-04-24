using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DunjinzAnDizeRollz.Resources;

namespace DunjinzAnDizeRollz.Models
{
    public class Player : BasePropertyChanged
    {
        public string Name { get; set; }

        private ICharacterClass characterClass;
        public ICharacterClass CharacterClass
        {
            get => characterClass;
            set
            {
                SetProperty(ref characterClass, value);
                TotalHitPoints = characterClass != null ? TotalHitPoints += characterClass.HitPointBonus : TotalHitPoints;
            }
        }

        public int Experience { get; set; }
        public int Level { get; set; }

        public int TotalHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }

        // TODO: Add up initiative from class and any other items or abilities that may increase initiative.
        public int TotalInitiativeBonus { get; set; }

        public IWeapon WeaponSlot { get; set; }
        public IArmour Armour { get; set; }
        public int Gold { get; set; }

        public Player()
        {
            Experience = 0;
            Level = 1;
            TotalHitPoints = 100;
            Gold = 0;
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
