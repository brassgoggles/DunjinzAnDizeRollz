using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models
{
    public class Menu
    {
        public string MenuTitle { get; set; }
        public List<Option> Options { get; set; }

        public Menu(string menuTitle, List<Option> options)
        {
            MenuTitle = menuTitle;
            Options = options;

            BuildMenu();
        }

        private void BuildMenu()
        {
            string output = $"-------------------- {MenuTitle} --------------------\n" +
                "[Press a number to select from the following]\n";

            for (int i = 0; i < Options.Count; i++)
            {
                output += $"{i + 1} - {Options[i].Title}\n";
            }

            output += "--------------------------------------------------\n\n";

            Console.WriteLine(output);

            int userInput;

            if(!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("!!!!! PLEASE ENTER A VALID OPTION !!!!!\n");
                BuildMenu();
            }

            if (userInput > 0 && userInput <= Options.Count)
            {
                Options[userInput - 1].Function();
            }
            else
            {
                BuildMenu();
            }
        }
    }

    public class Option
    {
        public string Title { get; set; }
        public Func<object> Function { get; set; }

        public Option(string title, Func<object> function)
        {
            Title = title;
            Function = function;
        }
    }
}
