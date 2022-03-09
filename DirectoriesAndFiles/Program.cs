using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\janis.griezans\samples";
            Console.WriteLine("Sisestage endale sobiv kausta nimi:");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Sisestage endale sobiv faili nimi:");
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
