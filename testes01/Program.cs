using testes01.Models;


// Pessoa pessoa= new Pessoa();
// Console.Write("Digite seu nome: ");
// pessoa.Nome = Console.ReadLine();
// Console.Write("Digite sua idade: ");
// pessoa.Idade = int.Parse(Console.ReadLine());
// pessoa.Apresentar();

DateTime dataAtual = DateTime.Now;
dataAtual.AddDays(5);


Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// Diferenca entre Convert e Parse: Convert transforma null em 0 ao inves de quebrar
int a = Convert.ToInt32("a");
int b = int.Parse("a");