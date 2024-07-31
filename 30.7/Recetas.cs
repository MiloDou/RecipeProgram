using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._7
{
    public class Recetas
    {
        

        public int[] Id {  get; set; }
        public string[] Name { get; set; }
        public string[] Description {  get; set; }
        public int Indice {  get; set; }
        public Recetas(int[] id, string[] name, string[] description, int index)
        {
            Id = id;
            Name = name;
            Description = description;
            Indice = index;
        }
        public int NewRecipe(int[] id, string[] name, string[] description, int index)
        {


            return Id[0];
        }



    }
}
