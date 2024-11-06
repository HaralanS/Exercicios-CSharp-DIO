using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public Pessoa()
        {            
        }

        public virtual void Apresentar()
        {
            Console.WriteLine("Ola, meu nome eh " + Nome + " e tenho " + Idade + " anos.");
        }
    }
}