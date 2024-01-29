using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
    internal class Veicolo
    {
        public string marca;
        public int anno;
        public string modello;

        public Veicolo(string marca, int anno, string modello)
        {
            this.marca = marca;
            this.modello = modello;
            this.anno = anno;
        }
        public void showVeicolo()
        {
            Console.WriteLine($"Il veicolo è :\t {this.marca}\n Il modello:\t {this.modello}\n Annata:\t {this.anno}");
        }
    }

}
