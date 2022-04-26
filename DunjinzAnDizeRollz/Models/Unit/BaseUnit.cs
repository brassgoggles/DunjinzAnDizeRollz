using DunjinzAnDizeRollz.Models.CharacterClasses;
using DunjinzAnDizeRollz.Models.Equipment.Armour;
using DunjinzAnDizeRollz.Models.Equipment.Weapons;
using DunjinzAnDizeRollz.Models.Races;
using DunjinzAnDizeRollz.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.Units
{
    // Base class for ALL creatures (including players and NPC's).
    public abstract class BaseUnit : BasePropertyChanged
    {
        #region Properties
        public string Name { get; set; }

        public string Tag { get; set; }

        private BaseRace race;

        public BaseRace Race
        {
            get => race;

            set
            {
                SetProperty(ref race, value);

                if (race != null)
                {
                    BaseHitPoints += race.HitPointBonus;
                    BaseDefence += race.DefenceBonus;
                    BaseDamageReduction += race.DamageReductionBonus;
                    BaseNumberOfMeleeAttacks += race.NumberOfMeleeAttacksBonus;
                    BaseInitiative += race.InitiativeBonus;
                    BaseWeightCapacity += race.WeightCapacityBonus;
                }
            }
        }

        private BaseCharacterClass characterClass;

        public BaseCharacterClass CharacterClass
        {
            get => characterClass;

            set
            {
                SetProperty(ref characterClass, value);

                if (characterClass != null)
                {
                    BaseHitPoints += characterClass.HitPointBonus;
                    BaseDefence += characterClass.DefenceBonus;
                    BaseDamageReduction += characterClass.DamageReductionBonus;
                    BaseNumberOfMeleeAttacks += characterClass.NumberOfMeleeAttacksBonus;
                    BaseInitiative += characterClass.InitiativeBonus;
                    BaseWeightCapacity += characterClass.WeightCapacityBonus;
                }
            }
        }

        public int Level { get; set; }

        // Each of the following properties have a "Base" value to represent
        // values that will be a permanent characterisic.

        // The "Total" value is the base + any modifiers from weapons,
        // armour, spells, etc.

        private int baseHitPoints;
        public int BaseHitPoints
        {
            get => baseHitPoints;
            set
            {
                SetProperty(ref baseHitPoints, value);
                ApplyHitPointBonuses();
            }
        }

        public int TotalHitPoints { get => BaseHitPoints; set { } }

        public int CurrentHitPoints { get; set; }

        private int baseMinDamage;
        public int BaseMinDamage
        {
            get => baseMinDamage;
            set
            {
                SetProperty(ref baseMinDamage, value);
                ApplyMinDamageBonuses();
            }
        }

        public int TotalMinDamage { get; set; }

        private int baseMaxDamage;
        public int BaseMaxDamage
        {
            get => baseMaxDamage;
            set
            {
                SetProperty(ref baseMaxDamage, value);
                ApplyMaxDamageBonuses();
            }
        }

        public int TotalMaxDamage { get; set; }

        private int baseDefence;
        public int BaseDefence
        {
            get => baseDefence;
            set
            {
                SetProperty(ref baseDefence, value);
                ApplyDefenceBonuses();
            }
        }

        public int TotalDefence { get; set; }

        private int baseDamageReduction;
        public int BaseDamageReduction
        {
            get => baseDamageReduction;
            set
            {
                SetProperty(ref baseDamageReduction, value);
                ApplyDamageReductionBonuses();
            }
        }

        public int TotalDamageReduction { get; set; }

        private int baseNumberOfMeleeAttacks;
        public int BaseNumberOfMeleeAttacks
        {
            get => baseNumberOfMeleeAttacks;
            set
            {
                SetProperty(ref baseNumberOfMeleeAttacks, value);
                ApplyNumberOfMeleeAttacksBonuses();
            }
        }

        public int TotalNumberOfMeleeAttacks { get; set; }

        private int baseInitiative;
        public int BaseInitiative
        {
            get => baseInitiative;
            set
            {
                SetProperty(ref baseInitiative, value);
                ApplyInitiativeBonuses();
            }
        }

        public int TotalInitiative { get; set; }

        private int baseWeightCapacity;
        public int BaseWeightCapacity
        {
            get => baseWeightCapacity;
            set
            {
                SetProperty(ref baseWeightCapacity, value);
                ApplyWeightCapacityBonuses();
            }
        }

        public int TotalWeightCapacity { get; set; }

        private IWeapon weaponSlot;

        public IWeapon WeaponSlot
        {
            get => weaponSlot;
            set
            {
                SetProperty(ref weaponSlot, value);
                ApplyBonuses();
            }
        }

        private IArmour armour;

        public IArmour Armour
        {
            get => armour;
            set
            {
                SetProperty(ref armour, value);
                ApplyBonuses();
            }
        } 
        #endregion

        public BaseUnit(string name,
                        string tag,
                        BaseRace race,
                        BaseCharacterClass characterClass,
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
            Name = name;
            Race = race;
            CharacterClass = characterClass;
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

        #region Apply bonuses
        private void ApplyBonuses()
        {
            ApplyHitPointBonuses();
            ApplyMinDamageBonuses();
            ApplyMaxDamageBonuses();
            ApplyDefenceBonuses();
            ApplyDamageReductionBonuses();
            ApplyNumberOfMeleeAttacksBonuses();
            ApplyInitiativeBonuses();
            ApplyWeightCapacityBonuses();
        }

        private void ApplyHitPointBonuses()
        {
            TotalHitPoints = baseHitPoints;
            TotalHitPoints += Race != null ? Race.HitPointBonus : 0;
            TotalHitPoints += CharacterClass != null ? CharacterClass.HitPointBonus : 0;
            TotalHitPoints += WeaponSlot != null ? WeaponSlot.HitPointBonus : 0;
            TotalHitPoints += Armour != null ? Armour.HitPointBonus : 0;
        }

        private void ApplyMinDamageBonuses()
        {
            TotalMinDamage = baseMinDamage;
            TotalMinDamage += Race != null ? Race.MinDamageBonus : 0;
            TotalMinDamage += CharacterClass != null ? CharacterClass.MinDamageBonus : 0;
            TotalMinDamage += WeaponSlot != null ? WeaponSlot.MinDamageBonus : 0;
            TotalMinDamage += Armour != null ? Armour.MinDamageBonus : 0;
        }

        private void ApplyMaxDamageBonuses()
        {
            TotalMaxDamage = baseMaxDamage;
            TotalMaxDamage += Race != null ? Race.MaxDamageBonus : 0;
            TotalMaxDamage += CharacterClass != null ? CharacterClass.MaxDamageBonus : 0;
            TotalMaxDamage += WeaponSlot != null ? WeaponSlot.MaxDamageBonus : 0;
            TotalMaxDamage += Armour != null ? Armour.MaxDamageBonus : 0;
        }

        private void ApplyDefenceBonuses()
        {
            TotalDefence = baseDefence;
            TotalDefence += Race != null ? Race.DefenceBonus : 0;
            TotalDefence += CharacterClass != null ? CharacterClass.DefenceBonus : 0;
            TotalDefence += WeaponSlot != null ? WeaponSlot.DefenceBonus : 0;
            TotalDefence += Armour != null ? Armour.DefenceBonus : 0;
        }

        private void ApplyDamageReductionBonuses()
        {
            TotalDamageReduction = baseDamageReduction;
            TotalDamageReduction += Race != null ? Race.DamageReductionBonus : 0;
            TotalDamageReduction += CharacterClass != null ? CharacterClass.DamageReductionBonus : 0;
            TotalDamageReduction += WeaponSlot != null ? WeaponSlot.DamageReductionBonus : 0;
            TotalDamageReduction += Armour != null ? Armour.DamageReductionBonus : 0;
        }

        private void ApplyNumberOfMeleeAttacksBonuses()
        {
            TotalNumberOfMeleeAttacks = baseNumberOfMeleeAttacks;
            TotalNumberOfMeleeAttacks += Race != null ? Race.NumberOfMeleeAttacksBonus : 0;
            TotalNumberOfMeleeAttacks += CharacterClass != null ? CharacterClass.NumberOfMeleeAttacksBonus : 0;
            TotalNumberOfMeleeAttacks += WeaponSlot != null ? WeaponSlot.NumberOfMeleeAttacksBonus : 0;
            TotalNumberOfMeleeAttacks += Armour != null ? Armour.NumberOfMeleeAttacksBonus : 0;
        }

        private void ApplyInitiativeBonuses()
        {
            TotalInitiative = baseInitiative;
            TotalInitiative += Race != null ? Race.InitiativeBonus : 0;
            TotalInitiative += CharacterClass != null ? CharacterClass.InitiativeBonus : 0;
            TotalInitiative += WeaponSlot != null ? WeaponSlot.InitiativeBonus : 0;
            TotalInitiative += Armour != null ? Armour.InitiativeBonus : 0;
        }

        private void ApplyWeightCapacityBonuses()
        {
            TotalWeightCapacity = baseWeightCapacity;
            TotalWeightCapacity += Race != null ? Race.WeightCapacityBonus : 0;
            TotalWeightCapacity += CharacterClass != null ? CharacterClass.WeightCapacityBonus : 0;
            TotalWeightCapacity += WeaponSlot != null ? WeaponSlot.WeightCapacityBonus : 0;
            TotalWeightCapacity += Armour != null ? Armour.WeightCapacityBonus : 0;
        }
        #endregion

        public abstract bool ActionTurn(BaseUnit opponent);

        public bool MeleeAttack(BaseUnit opponent)
        {
            Random random = new Random();

            // Roll to hit.
            DiceRoll diceRoll = new DiceRoll(numberOfDice: TotalNumberOfMeleeAttacks);

            int i = 1;

            foreach (var roll in diceRoll.Results)
            {
                Console.WriteLine($"***** {Name} attack roll {i} *****\n" +
                    $"{roll} vs {opponent.Name} defence: {opponent.TotalDefence}");

                if (opponent.CurrentHitPoints <= 0)
                {
                    Console.WriteLine($"{opponent.Name} has been slain.");
                    return false;
                }

                if (!CommonFunctions.RollCheck(roll, opponent.TotalDefence))
                    Console.WriteLine($"{Name} has missed.");
                else
                {
                    // Roll to damage.
                    int dmg = random.Next(TotalMinDamage, TotalMaxDamage + 1);
                    Console.WriteLine($"Damage by {Name}: {dmg}");
                    opponent.CurrentHitPoints -= dmg;
                }
                i++;
                Console.WriteLine($"Opponent HP: {opponent.CurrentHitPoints}\n\n\n");
                CommonFunctions.ProceedStory();
            }
            return true;
        }
    }
}
