using System;
using System.IO;

namespace ShoppingListFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\janis.griezans\samples";
            Console.WriteLine("Sisestage kausta nimeks 'shoppingList':");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Sisesta faili nimeks 'myShoppingList.txt'");
            string fileName = Console.ReadLine();

            //File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");

            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine("Directory and File already exist.");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }

        }
    }
}
