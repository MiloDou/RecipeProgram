using System;

namespace RecipeApp
{
    public class TRecetas
    {
        public int[] Id { get; set; }
        public string[] Name { get; set; }
        public string[] Description { get; set; }
        public int Indice { get; set; }

        public TRecetas(int[] id, string[] name, string[] description, int index)
        {
            Id = id;
            Name = name;
            Description = description;
            Indice = index;
        }

        public int NewRecipe()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("       ADD NEW RECIPE");
            Console.ResetColor();
            Console.WriteLine("------------------------------\n");

            try
            {
                Console.Write("Name recipe: ");
                Name[Indice] = Console.ReadLine();
                Console.Write("\nDescription: ");
                Description[Indice] = Console.ReadLine();
                Console.Write("ID recipe: ");
                Id[Indice] = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error found: " + ex.Message);
            }

            return ++Indice;
        }

        public void ConsultRecipe()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("       CONSULT RECIPE");
            Console.ResetColor();
            Console.WriteLine("------------------------------\n");
            Console.Write("Write name recipe: ");
            string recipeConsult = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < Indice; i++)
            {
                if (Name[i].Equals(recipeConsult, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"ID: {Id[i]}");
                    Console.WriteLine($"Recipe Name: {Name[i]}");
                    Console.WriteLine($"Description: {Description[i]}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("NO FOUND");
            }
        }

        public void ShowResume()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("            RESUME");
            Console.ResetColor();
            Console.WriteLine("------------------------------\n");

            if (Indice == 0)
            {
                Console.WriteLine("No recipes available.");
                return;
            }

            for (int i = 0; i < Indice; i++)
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine($"ID: {Id[i]}, Name: {Name[i]}, Description: {Description[i]}");
                Console.WriteLine("--------------------------------------------------------------");
            }
        }
    }
}
