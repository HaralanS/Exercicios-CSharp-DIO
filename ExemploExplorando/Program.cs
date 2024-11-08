﻿
using ExemploExplorando.Models;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

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


//         - - - - - - - - - - - -  - - Tratamento de erros / Try Catch - - - - - - - - - - - - - - - - - - -

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

//         - - - - - - - - - - - -  - - Filas / Pilhas / Dicionarios - - - - - - - - - - - - - - - - - - -


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

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SC", "Santana Catarina");
// estados.Add("SP", "Sao Paulo");
// estados.Add("PR", "Parana");

// foreach(KeyValuePair<string, string> estado in estados)
// {
//     Console.WriteLine($"{estado.Key} - {estado.Value}");
// }

// Console.WriteLine("* * * * *  * * * * * * * ");

// if(estados.ContainsKey("PR"))
// {
//     estados.Remove("PR");
// }

// estados["SP"] = "Sao Paulo Adulterdado";
// // Boolean temEstadoSP = estados.ContainsKey("SP");

// Console.WriteLine("* * * * *  * * * * * * * ");

// foreach(KeyValuePair<string, string> estado in estados)
// {
//     Console.WriteLine($"{estado.Key} - {estado.Value}");
// }

//         - - - - - - - - - - - -  - - Tuplas - - - - - - - - - - - - - - - - - - -

// (int id, string name, string surname) tupla = (1, "Haralan", "Santana");

// ValueTuple<int, string, string, decimal> tupla2 = (2, "Joao", "Silva", 1.8M);

// var tupla3 = Tuple.Create(3, "Pedro", "Souza", 1.95M);

// Console.WriteLine("Id: " + tupla.id + " - Nome: " + tupla.name + " - Sobrenome: " + tupla.surname);

// LeituraArquivo arquivo = new LeituraArquivo();

// (bool Sucesso, string[] Linhas, int QuantidadeLinhas) arquivoLido = arquivo.LerArquivo("Files/fileReading.txt");
// var (Sucesso, Linhas, QuantidadeLinhas) = arquivo.LerArquivo("Files/fileReading.txt"); // tipo desestruturacao
// var (Sucesso, Linhas, _) = arquivo.LerArquivo("Files/fileReading.txt"); // descarta a variavel que tem um underline no lugar

// Console.WriteLine("Sucesso: " + (arquivoLido.Sucesso ? "Sim" : "Nao"));
// foreach(string Linha in arquivoLido.Linhas)
// {
//     Console.WriteLine(Linha);
// }
// Console.WriteLine("Quantidade de linhas: " + arquivoLido.QuantidadeLinhas);

// Pessoa p1 = new Pessoa("Jao", "Silva", 15);

// (string nome, string sobrenome) = p1;

// Console.WriteLine("Nome: "+ nome + " - Sobrenome: " + sobrenome);

//         - - - - - - - - - - - -  - - JSON - - - - - - - - - - - - - - - - - - -

// List<Venda> listaVendas = new List<Venda>();

// DateTime dataAtual = DateTime.Now;

// Venda v1 = new Venda(1, "Material de Escritorio", 25.99M, dataAtual);
// Venda v2 = new Venda(1, "Licensa Software", 24.97M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Files/vendas.json", serializado);

// Console.WriteLine(serializado);

// string conteudoArquivo = File.ReadAllText("Files/vendas.txt");

// List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVendas)
// {
//     Console.WriteLine("Id: " + venda.Id);
//     Console.WriteLine("Nome: " + venda.Produto);
//     Console.WriteLine("Preco: " + venda.Preco);
//     Console.WriteLine("Data: " + venda.DataVenda.ToString("dd/MM/yyyy"));
// }

//         - - - - - - - - - - - -  - - Tipos Especiais  - - - - - - - - - - - - - - - - - - -

// bool? desejaReceberEmail = null;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuario optou receber email");
// }
// else
// {
//     Console.WriteLine("O usuario nao respondeu optou nao receber email");
// }


// string conteudoArquivo = File.ReadAllText("Files/vendas.json");

// List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVendas)
// {
//     Console.WriteLine("Id: " + venda.Id);
//     Console.WriteLine("Nome: " + venda.Produto);
//     Console.WriteLine("Preco: " + venda.Preco);
//     Console.WriteLine("Data: " + venda.DataVenda.ToString("dd/MM/yyyy"));
//     Console.WriteLine("Desconto: " + (venda.Desconto.HasValue ? venda.Desconto : 0M));
// }


// var tipoAnonimo = new {Nome = "Haralan", Sobrenome = "Santana", Altura = 1.76}; // Tipo anonimo

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);

// -- - - - --  -- - - Lista de anonimos
// string conteudoArquivo = File.ReadAllText("Files/vendas.json");

// List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVendas.Select(x => new {x.Produto, x.Preco});

// foreach (var venda in listaAnonimo)
// {
//     Console.WriteLine("- - - - - - - - - -");
//     Console.WriteLine("Nome: " + venda.Produto);
//     Console.WriteLine("Preco: " + venda.Preco);
//     Console.WriteLine("     -       ");
// }

// -- dinamica

// dynamic variavelDinamica = 4;
// Console.WriteLine("Tipo da variavel: " + variavelDinamica.GetType() + " - Valor: " + variavelDinamica);

// variavelDinamica = "Haralan";
// Console.WriteLine("Tipo da variavel: " + variavelDinamica.GetType() + " - Valor: " + variavelDinamica);

// -- CLasses Genericas

// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElemento(30);
// Console.WriteLine("Item 0: " + arrayInteiro[0]);

// -- Metodos de extensao

int numero = 20;
bool par = false;

par = numero.EhPar();

string mensagem = "O numero " + numero + " eh " + (par ? "par" : "impar");

Console.WriteLine(mensagem);