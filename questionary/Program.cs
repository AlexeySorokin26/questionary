using System;

namespace questionary {

    enum DaysOfWeek : byte
    {
        Monday, 
        Tuesday, 
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program {
        static void Main(string[] args) {

            (string name, int age) anketa;
            anketa.name = Console.ReadLine();

            Console.WriteLine("Input your fav color");
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            // как вас зовут, возраст, дату рождения.
            Console.WriteLine("What is your name?");
            var MyName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            var MyAge = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("When was you born?");
            var MyBirthday = Console.ReadLine();

            Console.WriteLine("Hello {0}! You are still quite young with your {1}! You birthday is nice {2}!",
                MyName, MyAge, MyBirthday);

            Console.ReadKey();
        
        }
    }
}
