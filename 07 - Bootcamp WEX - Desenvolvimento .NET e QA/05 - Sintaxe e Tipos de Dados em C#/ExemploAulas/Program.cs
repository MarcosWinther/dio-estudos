using ExemploAulas.Models;

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

dataAtual = DateTime.Now.AddDays(8);
Console.WriteLine(dataAtual);

// string apresentacao = "Hello World!";

// int quantidade = 2;

// double altura = 1.80;

// decimal valor = 1.80M;

// Console.WriteLine(apresentacao);
// Console.WriteLine(quantidade);
// Console.WriteLine(altura.ToString("0.00"));
// Console.WriteLine(valor);

// Pessoa p = new Pessoa();

// p.Nome = "Marcos Winther";
// p.Idade = 27;

// p.Apresentar();
