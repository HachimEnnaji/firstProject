using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veicolo auto = new Veicolo("Opel", 2020, "Zafira");
            auto.showVeicolo();
            Animale animal = new Animale("Vipera del Gabon", "Viperidi", 2);
            animal.showAnimale();
            Dipendente dipendente = new Dipendente("Marco", "Rossi", 37, "Impiegato");
            dipendente.showDipendente();
            Atleta atleta = new Atleta("Alberto", "Tomba", "Scii di fondo");
            atleta.showAtleta();
        }
    }
}
