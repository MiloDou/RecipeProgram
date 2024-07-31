
using RecipeApp;
using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Reflection;
class Program
{
    static void Main(string[] args)
    {
        int[] ids = new int[10];
        string[] names = new string[10];
        string[] descriptions = new string[10];
        int index = 0;

        TRecetas recetas = new TRecetas(ids, names, descriptions, index);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("       RECIPE MANAGER");
            Console.ResetColor();
            Console.WriteLine("------------------------------\n");
            Console.WriteLine("1. Add New Recipe");
            Console.WriteLine("2. Consult Recipe");
            Console.WriteLine("3. Show Resume");
            Console.WriteLine("4. Exit");
            Console.Write("\nSelect an option: ");

            int option;
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid option. Please try again.");
                continue;
            }

            switch (option)
            {
                case 1:
                    index = recetas.NewRecipe();
                    break;
                case 2:
                    recetas.ConsultRecipe();
                    break;
                case 3:
                    recetas.ShowResume();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
