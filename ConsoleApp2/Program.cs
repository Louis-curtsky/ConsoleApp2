using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var keepGoing = true;
            while (keepGoing)
            {
                int selection = 0;
                 printmenu();
                selection = UserInputNum("Select a menu: ");
                switch(selection)
                {
                    case 1:
                        GuestANumber();
                        break;
                    case 2:
                        Console.WriteLine($"{selection} selected!");
                        break;
                    case 3:
                        Console.WriteLine($"{selection} selected!");
                        break;
                    case 4:
                        Console.WriteLine($"{selection} selected!");
                        break;
                    case 99:
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection!!!");
                        break;
                }
                Console.Write("Hit anykey to continue!!!");
                Console.ReadKey();
            }
        }// End of Main

        private static void GuestANumber()
        {
            Random rannum = new Random();
            int guessNumInt = rannum.Next(1, 11);
            int userNumberInt = 0;
            bool ansMatch = false;
            do
            {
                userNumberInt = UserInputNum("Enter a Number: ");
                if (userNumberInt == guessNumInt)
                {
                    Console.Write($"Congratulation! Your are Right. The number is {guessNumInt} \nHit any key to exit the game!!!");
                    Console.ReadLine();
                    ansMatch = true;
                }
                else if (userNumberInt < guessNumInt)
                {
                    Console.WriteLine($"Your number {userNumberInt} is too low, try higher!!!");
                }
                else
                {
                    Console.WriteLine($"Your number {userNumberInt} is too high, try lower!!!");
                }

            } while (!ansMatch);
        }


        private static void printmenu()
        {
            Console.Clear();
            Console.WriteLine("----- Menu -----\n");
            Console.WriteLine("1: Guest a number");
            Console.WriteLine("2: Excercise 13");
            Console.WriteLine("3: Excercise 14");
            Console.WriteLine("4: Excercise 15");
            Console.WriteLine("99: Exit program");
            Console.WriteLine("\nEnter you choice: ");
        }

        private static int UserInputNum(string v)
        {
            bool isitnumber = false;
            int userSelInt = 0;
            Console.Write(v);
            isitnumber = int.TryParse(Console.ReadLine(), out userSelInt);
            if (!isitnumber)
            {
                Console.WriteLine("You are NOT entering a number!");
                Console.ReadLine();
                Console.Clear();
            }
            return userSelInt;
        }
    }// End of Program
}// End of namespaxce
