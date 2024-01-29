using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
    internal class Atleta
    {
        public string nome;
        public string cognome;
        public string categoria;
    
        public Atleta(string nome, string cognome, string categoria)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.categoria = categoria;
        }
        public void showAtleta()
        {
            Console.WriteLine($"Nome è :\t {this.nome}\n Cognome:\t {this.cognome}\n Nella categoria di:\t {this.categoria}");

        }
    }

}
