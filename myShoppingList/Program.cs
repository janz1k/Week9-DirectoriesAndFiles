using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace myShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\janis.griezans\samples\shoppingList";
            string fileName = @"\\myShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;


            while (loopActive)
            {
                Console.WriteLine("Kas sa soovid lisada toitu ostukorvi? y/n:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Lisa enda toit:");
                    string userFood = Console.ReadLine();
                    myShoppingList.Add(userFood);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Head päeva!");
                }

            }
            Console.Clear();

            foreach (string food in myShoppingList)
            {
                Console.WriteLine($"Your wish: {food}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);
        }
    }
}
