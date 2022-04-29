using DunjinzAnDizeRollz.Models;
using DunjinzAnDizeRollz.Models.Units;
using DunjinzAnDizeRollz.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Scenes
{
    public class Combat
    {
        public bool continueCombat { get; set; }
        public BaseUnit Opponent { get; set; }

        public Combat(BaseUnit opponent)
        {
            continueCombat = true;
            Opponent = opponent;

            InitiateCombat();
        }

        // Must be return type of object to be used as an argument in MenuBuilder.
        public object InitiateCombat()
        {
            Console.WriteLine($"Before you stands a {Opponent.Name}!\n\n");

            int i = 1;

            while (continueCombat)
            {
                Console.WriteLine($"*************** Round {i} ***************");
                Console.WriteLine("***** Roll for initiative *****");
                List<BaseUnit> attackQueue = Initiative(Opponent);
                CommonFunctions.ProceedStory();

                foreach (var unit in attackQueue)
                {
                    CombatAction combatAction = new();

                    if(unit.Tag == "player")
                    {
                        // Player gets to choose from a menu.
                        combatAction = PlayerCombatMenu();
                        CombatActionResultModifiers(combatAction, Program.player, Opponent);
                        Console.WriteLine($"{Opponent.Name} HP remaining: {Opponent.CurrentHitPoints}\n\n");
                    }
                    else
                    {
                        // Opponent attacks - later can choose to do a special move or drink a potion.
                        combatAction = Opponent.MeleeAttack(Program.player);
                        CombatActionResultModifiers(combatAction, Opponent, Program.player);
                    }

                    if (Program.player.CurrentHitPoints <= 0)
                    {
                        PlayerDeath();
                        //continueCombat = false;
                        return null;
                    }

                    if (Opponent.CurrentHitPoints <= 0)
                    {
                        OpponentDeath();
                        //continueCombat = false;
                        return null;
                    }
                }
                i++;
            }
            return null;
        }

        private void CombatActionResultModifiers(CombatAction combatAction, 
            BaseUnit activeUnit, BaseUnit opponent)
        {
            activeUnit.CurrentHitPoints -= combatAction.DamageTaken;
            activeUnit.CurrentHitPoints += combatAction.HealthRecovered;

            opponent.CurrentHitPoints -= combatAction.DamageDealt;

            Console.WriteLine($"{activeUnit.Name} total damage to {opponent.Name}: {combatAction.DamageDealt}\n" +
                $"{opponent.Name} total HP remaining: {opponent.CurrentHitPoints}\n\n");
        }

        private void PlayerDeath()
        {
            Console.WriteLine("You have been slain.\n\n");

            // TODO: Penalty for dieing.
            Console.WriteLine("!!!!! PENALTY FOR DIEING NOT YET IMPLEMENTED !!!!!\n\n");
        }

        private void OpponentDeath()
        {
            Console.WriteLine($"{Opponent.Name} has been slain.\n\n");

            // TODO: EXP and Treasure rewards.
            Console.WriteLine("!!!!! REWARDS NOT YET IMPLEMENTED !!!!!\n\n");
        }

        private CombatAction PlayerCombatMenu()
        {
            CombatAction combatAction = new();

            List<Option> menuOptions = new List<Option>()
            {
                new Option("Melee attack", () => combatAction = Program.player.MeleeAttack(Opponent)),
                new Option("Do nothing", () => null)
            };

            Menu menu = new("COMBAT MENU", menuOptions);

            return combatAction;
        }

        // Work out the attack order of everyone involved in the combat.
        private List<BaseUnit> Initiative(BaseUnit opponent)
        {
            Random random = new Random();

            int opponentRoll = random.Next(1, 101) + opponent.TotalInitiative;
            int playerRoll = random.Next(1, 101) + Program.player.TotalInitiative;

            Console.WriteLine($"Opponent initiative: {opponentRoll}");
            Console.WriteLine($"Player initiative: {playerRoll}\n\n");

            if (playerRoll > opponentRoll)
            {
                // Player goes first.
                return new List<BaseUnit>()
                {
                    Program.player,
                    opponent
                };
            }
            else if (playerRoll < opponentRoll)
            {
                // Opponent goes first.
                return new List<BaseUnit>()
                {
                    opponent,
                    Program.player
                };
            }
            else
            {
                // Both have same initiative, trigger reroll.
                return Initiative(opponent);
            }
        }
    }
}
