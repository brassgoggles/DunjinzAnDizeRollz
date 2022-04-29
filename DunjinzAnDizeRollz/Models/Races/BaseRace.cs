using DunjinzAnDizeRollz.Scenes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.Races
{
    public class BaseRace : ICharacteristicBonuses
    {
        public string RaceName { get; set; }
        public int HitPointBonus { get; set; }
        public int DefenceBonus { get; set; }
        public int MinDamageBonus { get; set; }
        public int MaxDamageBonus { get; set; }
        public int DamageReductionBonus { get; set; }
        public int NumberOfMeleeAttacksBonus { get; set; }
        public int InitiativeBonus { get; set; }
        public int WeightCapacityBonus { get; set; }

        public List<CombatAction> RaceAbilities { get; set; }
    }
}
