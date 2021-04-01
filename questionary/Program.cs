using System;

namespace questionary {


    class Program {


        static int GetCorrectNumber(string greetings)
        {
            string number;
            int intnumber;
            do
            {
                Console.WriteLine(greetings);
                number = Console.ReadLine();
            } while (!CheckNum(number, out intnumber));
            return intnumber;
        }
        static bool CheckNum(string number, out int corrnumber)
        {
            if(int.TryParse(number, out int intnum))
            {
                if(intnum > 0)
                {
                    corrnumber = intnum;
                    return true;
                }
            }
            {
                corrnumber = 0;
                return false;
            }
            
        }
        static string[] CreateArr(in int num)
        {
            string[] arr = new string[num];
            return arr;
        }
        static void PrintUserInfo((string name, string surname, int age, bool hasPet, int amountPets, string[] pets, int amountFavColors, string[] colors) anketa)
        {
            Console.WriteLine("Hello, {0} {1}! You quite young with your {2}!", anketa.name, anketa.surname, anketa.age);
            if (anketa.hasPet && anketa.amountPets > 1)
            {
                Console.WriteLine("Cool! You have pets!");
                foreach (var pet in anketa.pets)
                {
                    Console.WriteLine("You have a nice pet {0}!", pet);
                }
            }
            else if (anketa.hasPet && anketa.amountPets == 1)
            {
                Console.WriteLine("Cool! You have pet!");
            }
            foreach (var color in anketa.colors)
            {
                Console.WriteLine("You have a nice favorite color {0}!", color);
            }
            
        }

        static (string name, string surname, int age, bool hasPet, int amountPets, string[] pets, int amountFavColors, string[] colors) FillUserInfo()
        {
            (string name, string surname, int age, bool hasPet, int amountPets, string[] pets, int amountFavColors, string[] colors) anketa;

            Console.WriteLine("type your name");
            anketa.name = Console.ReadLine();

            Console.WriteLine("type your surname");
            anketa.surname = Console.ReadLine();

            anketa.age = GetCorrectNumber("type your age in digitals");

            Console.WriteLine("do you have pets? Type yes or no");
            string res = Console.ReadLine();
            anketa.hasPet = false;
            if (res == "yes") {
                anketa.hasPet = true;
                Console.WriteLine("how many pets do you have?");
                anketa.amountPets = GetCorrectNumber("type amount of pets you have in digitals");
                anketa.pets = CreateArr(anketa.amountPets);
                for(int i = 0; i < anketa.amountPets; ++i)
                {
                    Console.WriteLine("type you pets' name, rest pets to type {0}", anketa.amountPets - i - 1);
                    anketa.pets[i] = Console.ReadLine();
                }
            }
            else
            {
                anketa.amountPets = 0;
                anketa.pets = new string[anketa.amountPets];
            }

            Console.WriteLine("how many favorite colors do you have?");
            anketa.amountFavColors = GetCorrectNumber("type amount of your favorite numbers"); ;
            anketa.colors = CreateArr(anketa.amountFavColors);
            for (int i = 0; i < anketa.amountFavColors; ++i)
            {
                Console.WriteLine("type you favorite color, rest colors to type {0}", anketa.amountFavColors - i - 1);
                anketa.colors[i] = Console.ReadLine();
            }
            return anketa;
        }

        static void Main(string[] args) {

            var anketa = FillUserInfo();
            PrintUserInfo(anketa);
            
            Console.ReadKey();
        }
    }
}
