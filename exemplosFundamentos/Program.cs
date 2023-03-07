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

new ExemploExcecao().Metodo1();