namespace DunjinzAnDizeRollz.Scenes
{
    public class CombatAction
    {
        // The CombatAction class can be used to return a variety of different
        // results from a combat action such as melee attack, spell or potion consumed.

        public int DamageDealt { get; set; }
        public int DamageTaken { get; set; }
        public int HealthRecovered { get; set; }
        // TODO: Add other actions for example "DefenceBonusRecieved"

        public CombatAction() { }
    }
}
