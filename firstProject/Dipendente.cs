using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
    internal class Dipendente
    {
        public string nome;
        public string cognome;
        public int eta;
        public string mansione;

        public Dipendente(string nome, string cognome, int eta, string mansione)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
            this.mansione = mansione;
        }

        public void showDipendente()
        {
            Console.WriteLine($"Nome :\t {this.nome}\n Cognome:\t {this.cognome}\n E ha l'eta' di:\t {this.eta} anni\n Copre la mansione di:\t {this.mansione}");

        }
    }
}
