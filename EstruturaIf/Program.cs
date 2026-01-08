using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Executando projeto Estrutura IF");

Console.WriteLine("Informe o valor de x \t");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y \t");
int y = Convert.ToInt32(Console.ReadLine());

string result = (x > y) ? "x é maior que y" : "x é menor ou igual a y";

Console.WriteLine(result);

Console.ReadKey();