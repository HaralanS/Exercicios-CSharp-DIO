using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }
        public string Email { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine("Ola, meu nome eh " + Nome + ", tenho " + Idade + " anos e sou um aluno nota " + Nota);
        }
    }
}