using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome
        {
            // get
            // {
            //     return _nome.ToUpper();
            // }
            get => _nome.ToUpper();

            // set => _nome = value;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome nao pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade nao pode ser menor que zero");
                }

                _idade = value;
            }
        }

        public Pessoa()
        {

        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto.ToUpper()}, Idade: {Idade}");
        }
    }
}