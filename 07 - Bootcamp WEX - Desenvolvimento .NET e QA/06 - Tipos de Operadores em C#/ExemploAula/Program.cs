// int a = 6;
// int b = 4;
// int c = a + b;

// Console.WriteLine(c);

// int a = Convert.ToInt32("5");

// Console.WriteLine(a);

// int b = int.Parse("20");

// Console.WriteLine(b);

// int a = 20;

// string b = a.ToString();

// Console.WriteLine(b);

// int a = 20;
// double b = a;

// Console.WriteLine(b);

// string a = "15m";
// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);

// int valor1 = 20;
// int valor2 = 40;

// if(valor1 > valor2) {
//    Console.WriteLine("O valor 1 é maior ou igual ao valor 2.");
// } else if(valor2 > valor1) {
//    Console.WriteLine("O valor 2 é maior.");
// } else {
//    Console.WriteLine("Os valores são iguais.");
// }

// Console.WriteLine($"Valor 1: {valor1}");
// Console.WriteLine($"Valor 2: {valor2}");
// Console.WriteLine($"O valor 1 é maior que o valor 2? {valor1 > valor2}");

// Console.WriteLine("Digite uma letra:");
// string? letra = Console.ReadLine();

// switch(letra)
// {
//    case "a":
//    case "e":
//    case "i":
//    case "o":
//    case "u":
//       Console.WriteLine("Vogal");
//       break;
//    default:
//       Console.WriteLine("Não é vogal!");
//       break;
// }

bool possuiPresencaMinima = true;
double media = 7.5;

if(possuiPresencaMinima && media >= 7) {
   Console.WriteLine("Aprovado!");
} else {
   Console.WriteLine("Reprovado!");
}