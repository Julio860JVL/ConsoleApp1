using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Switch1(bool switch1)
        {
            if (switch1 == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  ACTIVE   ");
                Console.ResetColor();
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("    OFF    ");
                Console.ResetColor();
                return;
            }
        }

        public static void Switch2(bool switch2)
        {
            if (switch2 == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  ACTIVE  ");
                Console.ResetColor();
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("    OFF   ");
                Console.ResetColor();
                return;
            }
        }

        public static void Switch3(bool switch3)
        {
            if (switch3 == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  ACTIVE");
                Console.ResetColor();
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("    OFF");
                Console.ResetColor();
                return;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("SWITCH # 1. --- SWITCH # 2 --- SWITCH # 3");
            Switch1(true);
            Console.Write(" --- ");
            Switch2(true);
            Console.Write(" --- ");
            Switch3(true);
            Console.WriteLine();

            Console.Write("Flip Switch: [1] [2] [3] --> ");
            var pressedKey = Console.ReadLine();
            Console.WriteLine(pressedKey);
        }
    }
}
