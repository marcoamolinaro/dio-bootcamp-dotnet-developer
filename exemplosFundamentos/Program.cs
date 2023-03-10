using exemplosFundamentos.Models;

// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!");
Pessoa pessoa = new Pessoa();
pessoa.Nome = "Marco";
pessoa.Idade = 59;
pessoa.Apresentar(); */

// double altura = 1.80;
// decimal preco = 1.80M;

// Console.WriteLine("Altura " + altura);
// Console.WriteLine("Altura " + altura.ToString("0.00"));
// Console.WriteLine("Preço " + preco);

// try 
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoleitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu erro na leitura do arquivo. Pasta não encontrada. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui!");
// }

//new ExemploExcecao().Metodo1();

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// imprimir();

// while (fila.Count != 0) 
// {
//     fila.Dequeue();
//     imprimir();
// }

// void imprimir() 
// {
//     Console.WriteLine("=========");
//     foreach (int item in fila)
//     {
//         Console.WriteLine(item);
//     }
// }

// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// imprimir();

// while (pilha.Count != 0) 
// {
//     Console.WriteLine($"Removendo {pilha.Pop()}");
//     imprimir();
// }


// void imprimir()
// {
//     Console.WriteLine("======");
//     foreach (int item in pilha)
//     {
//         Console.WriteLine(item);
//     }
// }

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

//foreach (var item in estados) - Pode usar o tipo como sendo var que ele reconhece como um KeyValuePair
foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("=======================");

//estados.Remove("BA");
estados["SP"] = "Piracicaba";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "BA";
Console.WriteLine($"Verificando se o elemento {chave} já existe");

if (estados.ContainsKey(chave))
{
    Console.WriteLine("Valor existente");
}
else 
{
    Console.WriteLine("Valor não existe");
}

Console.WriteLine(estados["RJ"]);
Console.WriteLine("Teste");