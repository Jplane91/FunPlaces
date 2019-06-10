using System;

namespace FunPlaces
{
    class Recommendations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("\n{0}, what type of activity are you in the mood for? (Enter the corresponding number)\n\nHere are your options:\n1)Action\n2)Chill Times\n3)Danger\n4)Good Food", name);
            int activity = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\nHow many people will you be brining?");
            int people = int.Parse(Console.ReadLine());


            if (activity == 1 && people == 0)

            {
                Console.WriteLine("\nYou should take a walk to stock car racing!");
            }

            else if (activity == 1 && people > 0 && people < 5)
            {
                Console.WriteLine("\nYou should drive a sedan to stock car racing!");
            }

            else if (activity == 1 && people > 4 && people < 11)
            {
                Console.WriteLine("\nYou should take a bus to stock car racing!");
            }

            else if (activity == 1 && people >= 11)
            {
                Console.WriteLine("\nYou should take an airplane to stock car racing!");
            }

            else if (activity == 2 && people == 0)

            {
                Console.WriteLine("\nYou should take a walk to the nearest hiking trail!");
            }

            else if (activity == 2 && people > 0 && people < 5)
            {
                Console.WriteLine("\nYou should drive a sedan to the nearest hiking trail!");
            }

            else if (activity == 2 && people > 4 && people < 11)
            {
                Console.WriteLine("You should take a bus to the nearest hiking trail!");
            }

            else if (activity == 2 && people >= 11)
            {
                Console.WriteLine("\nYou should take an airplane to the nearest hiking trail!");
            }

            else if (activity == 3 && people == 0)

            {
                Console.WriteLine("\nYou should take a walk to go skydiving!");
            }

            else if (activity == 3 && people > 0 && people < 5)
            {
                Console.WriteLine("\nYou should drive a sedan to go skydiving!");
            }

            else if (activity == 3 && people > 4 && people < 11)
            {
                Console.WriteLine("\nYou should take a bus to go skydiving!");
            }

            else if (activity == 3 && people >= 11)
            {
                Console.WriteLine("\nYou should take an airplane to go skydiving!");
            }

            else if (activity == 4 && people == 0)

            {
                Console.WriteLine("\nYou should take a walk to the nearest Taco Bell!");
            }

            else if (activity == 4 && people > 0 && people < 5)
            {
                Console.WriteLine("\nYou should drive a sedan to nearest Taco Bell!");
            }

            else if (activity == 4 && people > 4 && people < 11)
            {
                Console.WriteLine("\nYou should take a bus to nearest Taco Bell!");
            }

            else if (activity == 4 && people >= 11)
            {
                Console.WriteLine("\nYou should take an airplane to the nearest Taco Bell!");
            }

            else
            {
                Console.WriteLine("\nInvalid input");
            }

            {
                Console.WriteLine("\n\n\nThank you, and enjoy your day");
            }
        }

    }
}
