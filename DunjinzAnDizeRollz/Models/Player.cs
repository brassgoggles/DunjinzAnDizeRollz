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

        public Player(string name,
                      BaseRace race,
                      BaseCharacterClass characterClass,
                      int experience,
                      int gold,
                      string tag = "player",
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

        public override bool ActionTurn(BaseUnit opponent)
        {
            // Show menu with choices.
            //  - Melee attack
            //  - Cast spell
            //  - Use ability
            //  - Drink potion

            // TODO: Update the menu and the actions that follow.
            Console.WriteLine("---------------------- MENU ----------------------\n" +
                "[Press a number to select from the following]\n" +
                "1 - Melee attack\n" +
                "2 - Do nothing\n" +
                "--------------------------------------------------\n\n");

            string selection = Console.ReadLine();

            if (selection == "1")
            {
                return MeleeAttack(opponent);
            }
            return MeleeAttack(opponent);
        }

        //public override bool MeleeAttack(BaseUnit opponent)
        //{
        //    Random random = new Random();

        //    // Roll to hit.
        //    DiceRoll diceRoll = new DiceRoll(numberOfDice: TotalNumberOfMeleeAttacks);

        //    int i = 1;

        //    foreach (var roll in diceRoll.Results)
        //    {
        //        Console.WriteLine($"***** {Name} attack roll {i} *****\n" +
        //            $"{roll} vs {opponent.Name} defence: {opponent.TotalDefence}");

        //        if (opponent.CurrentHitPoints <= 0)
        //        {
        //            Console.WriteLine($"{opponent.Name} has been slain.");
        //            return false;
        //        }                    

        //        if (!CommonFunctions.RollCheck(roll, opponent.TotalDefence))
        //            Console.WriteLine($"{Name} has missed.");
        //        else
        //        {
        //            // Roll to damage.
        //            int dmg = random.Next(TotalMinDamage, TotalMaxDamage + 1);
        //            Console.WriteLine($"Damage by {Name}: {dmg}");
        //            opponent.CurrentHitPoints -= dmg;
        //        }
        //        i++;
        //        Console.WriteLine($"Opponent HP: {opponent.CurrentHitPoints}\n\n\n");
        //        CommonFunctions.ProceedStory();
        //    }
        //    return true;
        //}
    }
}
