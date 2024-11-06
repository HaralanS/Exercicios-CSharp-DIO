using ExemploPOO.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Haralan";
// p1.Idade = 35;

// p1.Apresentar();

// ContaCorrente c1 = new ContaCorrente(123, 1000);

// c1.ExibirSaldo();

// c1.Sacar(15489);

// c1.ExibirSaldo();


Professor p1 = new Professor();
p1.Nome = "Joao";
p1.Idade = 45;
p1.Salario = 1999.99M;

Aluno a1 = new Aluno();
a1.Nome = "Pedrinho";
a1.Idade = 20;
a1.Email = "pedrinho@email.com";
a1.Nota = 10;

p1.Apresentar();
a1.Apresentar();