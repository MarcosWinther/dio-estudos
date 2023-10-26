int numero = 10;

for (int contador = 0; contador <= 10; contador++)
{
   Console.WriteLine($"{numero} * {contador} = {numero * contador}");
}

int conta = 0;

while (conta <= 10)
{
   Console.WriteLine($"{numero} + {conta} = {numero + conta}");
   conta++;
}

int soma = 0, num = 0;

do {
   Console.WriteLine("Digite um número (0 para)");
   num = Convert.ToInt32(Console.ReadLine());
   soma += num;
} while (num != 0);

Console.WriteLine($"Soma dos números digitados = {soma}");

