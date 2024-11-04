
using ExemploExplorando.Models;
using System.Globalization;
using System.Runtime.CompilerServices;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// Pessoa p1 = new Pessoa("Haralan", "Santana", 15);

// Pessoa p2 = new Pessoa("Joao", "Silva", 15);

// Pessoa p3 = new Pessoa("Pedro", "Souza", 15);


// Curso curso= new Curso();
// curso.Nome = "Curso de Ingles";

// curso.AdicionarAluno(p1);
// curso.AdicionarAluno(p2);
// curso.AdicionarAluno(p3);
// curso.ListarAlunos();
// curso.RemoverAluno(p2);
// curso.ListarAlunos();

// decimal valorMonetario = 1582.40M;

// double porcentagem = .3214;

// int numero = 123456;

// Console.WriteLine($"{valorMonetario:C}");

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

// Console.WriteLine(porcentagem.ToString("P"));

// Console.WriteLine(numero.ToString("##-##-##"));

// Console.WriteLine("------ - - - - - - - - - - - -- ");

// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

// Console.WriteLine("------ - - - - - - - - - - - -- ");

// DateTime data2 = DateTime.Parse("04/17/2024 18:00");

// Console.WriteLine(data2.ToString("dd/MM/yyyy HH:mm"));

// string dataString = "2022-12-17 18:00";

// bool sucess = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucess) {
//     Console.WriteLine("Conversao com sucesso, data: " + data.ToString("dd/MM/yyyy HH:mm"));
// } else {
//     Console.WriteLine("Data invalida: " + dataString);
// }

// DateTime data = DateTime.Parse(dataString);




// try
// {
//     string[] linhas = File.ReadAllLines("Files/fileReading.txt");

//     foreach (string linha in linhas) 
//     {
//         Console.WriteLine(linha);
//     }

// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine("Nao foi possivel encontrar o arquivo =,(");
//     Console.WriteLine(ex.Message);
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine("Nao foi possivel encontrar o diretorio do arquivo =,(");
//     Console.WriteLine(ex.Message);
// }
// catch (Exception ex)
// {
    
//     Console.WriteLine(ex.Message);
// }
// finally
// {
//     Console.WriteLine("Processo de leitura finalizado :D");
// }

// new ExemploExcecao().Metodo1();


// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine("* * * * *  * * * * * ** ");

// Console.WriteLine($"Removendo da fila o item: {fila.Dequeue()}");

// Console.WriteLine("* * * * *  * * * * * ** ");

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Stack<int> pilha = new Stack<int>();
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine("* * * * *  * * * * * ** ");

// Console.WriteLine($"Removendo da pilha o item: {pilha.Pop()}");

// Console.WriteLine("* * * * *  * * * * * ** ");

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SC", "Santana Catarina");
estados.Add("SP", "Sao Paulo");
estados.Add("PR", "Parana");

foreach(KeyValuePair<string, string> estado in estados)
{
    Console.WriteLine($"{estado.Key} - {estado.Value}");
}

Console.WriteLine("* * * * *  * * * * * * * ");

if(estados.ContainsKey("PR"))
{
    estados.Remove("PR");
}

estados["SP"] = "Sao Paulo Adulterdado";
// Boolean temEstadoSP = estados.ContainsKey("SP");

Console.WriteLine("* * * * *  * * * * * * * ");

foreach(KeyValuePair<string, string> estado in estados)
{
    Console.WriteLine($"{estado.Key} - {estado.Value}");
}