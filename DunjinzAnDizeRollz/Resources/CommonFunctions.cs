using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Resources
{
    public static class CommonFunctions
    {
        public static bool RollCheck(int score, int againstNumber)
        {
            return score >= againstNumber ? true : false;
        }

        public static void ProceedStory()
        {
            Console.WriteLine("[ENTER] to proceed...\n\n");
            string key = Console.ReadKey().Key.ToString();
            if (key != "Enter")
            {
                Console.WriteLine("Please press [ENTER] key...");
                ProceedStory();
            }
        }
    }
}
