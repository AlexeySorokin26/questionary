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
