using MyApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{

    class MyProgram
    {
       //Creating an Array
        static void Main(string[] args)
        {
            string[] dogNames = { "Molly", "Winter", "Gucci" };
            int[] dogAges = { 3, 2, 1 };

            Console.WriteLine("Enter Dog Name: ");
            string NameOfDogs = Console.ReadLine();

            bool contains = false;
            int AgeOfDogs = 0;

            for (int i = 0; i < dogNames.Length; i++)
            {
                if (NameOfDogs == dogNames[i])
                {
                    contains = true;
                    AgeOfDogs = dogAges[i];
                    break;
                }
            }

            if (contains == true)
            {
                Console.WriteLine("{0} is now {1} year/s old", NameOfDogs, AgeOfDogs);
            }
            else
            {
                Console.WriteLine("default");
            }            
        }
    }
}
