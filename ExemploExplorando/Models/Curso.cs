using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; } = new List<Pessoa>();


        public void AdicionarAluno(Pessoa pessoa)
        {
            Alunos.Add(pessoa);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            return Alunos.Count;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            foreach(Pessoa pessoa in Alunos)
            {
                Console.WriteLine(pessoa.NomeCompleto);
            }
        }
    }
}