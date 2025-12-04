Console.WriteLine("Valores Double, Decimal e Float");

double doubleValue = 12345.6789;
float floatValue = 1.32f;
decimal decimalValue = 123456789.123456789m;

Console.WriteLine($"Valor Double: {doubleValue}");
Console.WriteLine($"Valor Float: {floatValue}");
Console.WriteLine($"Valor Decimal: {decimalValue}");


Console.WriteLine("\nOperações matemáticas");
float divisionFloat = 10f / 3f;
double divisionDouble = 10d / 3d;
decimal divisionDecimal = 10m / 3m;
Console.WriteLine($"""
    Divisão Float: {divisionFloat}
    Divisão Double: {divisionDouble} 
    Divisão Decimal: {divisionDecimal} 
    """);

Console.ReadLine();
