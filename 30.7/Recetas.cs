using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _30._7
{
    public class Recetas
    {


        public int[] Id { get; set; }
        public string[] Name { get; set; }
        public string[] Description { get; set; }
        public int Indice { get; set; }
        public Recetas(int[] id, string[] name, string[] description, int index)
        {
            Id = id;
            Name = name;
            Description = description;
            Indice = index;
        }
        public int NewRecipe(int[] id, string[] name, string[] description, int index)
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("       ADD NEW PRODUCT");
            Console.ResetColor();
            Console.WriteLine("------------------------------\n");
            try
            {
                Console.WriteLine("Name recipe: ");
                name[index] = Console.ReadLine();
                Console.WriteLine("Description: ");
                description[index] = Console.ReadLine();
            }
            catch (FormatException MessageError1)
            {

                Console.WriteLine("Error found: " + MessageError1);
            }
            Console.WriteLine("ID recipe: ");
            id[index] = Convert.ToInt32(Console.ReadLine());


            return index++;
        }
        public void ConsultRecipe()
        {
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("       CONSULT PRODUCT");
            Console.ResetColor();
            Console.WriteLine("------------------------------\n");
            Console.WriteLine("Write name recipe: ");
            string RecipeConsult = Console.ReadLine();
            for (int i = 0; i < Indice; i++)
            {
                if (Name[i] == RecipeConsult)
                {
                    Console.WriteLine($"ID: {Id[i]}");
                    Console.WriteLine($"Recipe Name: {Name[i]}");
                    Console.WriteLine($"Description: {Description[i]}");
                }
                else
                    Console.WriteLine("Recipe NO FOUND");
            }

        }
        public void ShowResume()
        {
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("            RESUMÉ  ");
            Console.ResetColor();
            Console.WriteLine("------------------------------\n");

            for (int i = 0; i < Indice; i++)
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine($"ID: {Id[i]}, Name: {Name[i]}, Desciption: { Description[i]}");
                Console.WriteLine("--------------------------------------------------------------");
            }


        }
    }
}
