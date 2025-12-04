Console.WriteLine("Atribuindo valores para bool e char");

bool isTrue = true;
bool isFalse = false;

Console.WriteLine($"É verdadeiro: {isTrue}");
Console.WriteLine($"É verdadeiro: {isFalse}");

Console.WriteLine(10 > 15 ? isTrue : isFalse); // Operador ternário
Console.WriteLine(10 < 15 ? isTrue : isFalse);

char letterA = 'A';
char letterAUnicode = '\u0041';
Console.WriteLine($"Letra A: {letterA}");
Console.WriteLine($"Letra A com caractere Unicode: {letterAUnicode}");
