using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine("Ola, meu nome eh " + Nome + ", tenho " + Idade + " anos e sou um professor que ganha R$ " + Salario);
        }
    }

}