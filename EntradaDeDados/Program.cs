Console.WriteLine("## Entrada de dados ##");
Console.Write("\nInforme o seu nome:");
string name = Console.ReadLine();
Console.Write("\nInforme o sua idade:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"O seu nome é {name}");
Console.WriteLine($"Você tem {age} anos");
Console.ReadKey();