using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public sealed class Professor : Pessoa
    {
        public Professor()
        {            
        }
        public Professor(string nome) : base(nome)
        {
        }

        public decimal Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine("Ola, meu nome eh " + Nome + ", tenho " + Idade + " anos e sou um professor que ganha R$ " + Salario);
        }
    }

}