using System;
using System.Collections.Generic;

namespace ForEach_Loop
{
    class Program
    {
        static void Main(string[] args)
        {


            //List<string> firstNames = new List<string>();

            //firstNames.Add("Alex");
            //firstNames.Add("Boob");
            //firstNames.Add("James");
            //firstNames.Add("Mark");

            //foreach (string name in firstNames)
            //{
            //    Console.WriteLine(name);
            //}

            //Dictionary<int, string> importantYears = new Dictionary<int, string>();

            //importantYears.Add(1492, "Columbus arrives in America.");
            //importantYears.Add(1460, "Something happend in 1460");
            //importantYears.Add(1800, "Something happend in 1800.");
            //importantYears.Add(1990, "Someone was born in 1990");

            //foreach (var year in importantYears)
            //{
            //    Console.WriteLine($"{year.Key}:{year.Value}");
            //}

            // USE FOREACH LOOP Whenever possible for performing loops over lists.


            string nameText = "";
            string optionSelection = "";
            int capacityNameList = 4; // 0,1,2,3,4 -> 5 names capacity
            List<string> nameList = new List<string>(capacityNameList);


            do
            {
                Console.WriteLine("Please insert your name:");
                nameText = Console.ReadLine();
                nameList.Add(nameText);
                Console.WriteLine("Do you want to continue? yes or no");
                optionSelection = Console.ReadLine();


            } while (nameList.Capacity == capacityNameList);

            Console.WriteLine("The list is: ");

            foreach (var name in nameList)
            {
                Console.WriteLine($"{name}");

            }


            Console.ReadLine();
        }
    }
}
