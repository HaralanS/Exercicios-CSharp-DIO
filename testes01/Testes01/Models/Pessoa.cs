using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testes01.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome eh {Nome} e tenho {Idade} anos");
        }
    }
}