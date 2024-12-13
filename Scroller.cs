using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sea
{
    class Scroller
    {
        private static int ChosenIndex;
        private string[] Options;
        private string Prompt;

        public Scroller(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            ChosenIndex = 0;
        }
        private void ShowOption()
        {
            Console.WriteLine(Prompt);
            Console.CursorVisible = false;
            for (int i = 0; i < Options.Length; i++)
            {
                string Opt = Options[i];
                string identifier;

                if (i == ChosenIndex)
                {
                    identifier = "><>";
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    identifier = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($" {identifier}  [{Opt}] ");
            }
            Console.ResetColor();
        }
        public int Navigate()
        {
            ChosenIndex = 0;
            ConsoleKey keyPressed;
            Console.CursorVisible = false;
            do
            {
                Console.Clear();
                ShowOption();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    ChosenIndex--;
                    if (ChosenIndex == -1)
                    {
                        ChosenIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    ChosenIndex++;
                    if (ChosenIndex == Options.Length)
                    {
                        ChosenIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);

            return ChosenIndex;
        }
    }
}
