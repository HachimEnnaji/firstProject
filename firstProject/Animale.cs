using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
    internal class Animale
    {

        public string specie;
        public string  famiglia;
        public int eta;

        public Animale(string specie, string famiglia, int eta)
        {
            this.specie = specie;
            this.famiglia = famiglia;
            this.eta = eta;
        }
        public void showAnimale()
        {
            Console.WriteLine($"L'animale è :\t {this.specie}\n Della famiglia:\t {this.famiglia}\n E ha l'eta' di:\t {this.eta} anni");

        }
    }
}
