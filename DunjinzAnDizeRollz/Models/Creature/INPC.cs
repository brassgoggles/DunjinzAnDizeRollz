using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models.Creature
{
    public interface INPC
    {
        public int ExperienceValue { get; set; }
        public int RewardLevel { get; set; }
    }
}
