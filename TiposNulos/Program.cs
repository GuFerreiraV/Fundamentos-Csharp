Console.WriteLine("Tipos nuláveis");

//int valor = null; // Erro de compilação: Cannot convert null to 'int' because it is a non-nullable value type
//Console.WriteLine(valor);


// csharp 8.0 - nullabletypes

Nullable<int> valorNulo = null;
double? salario = null;
Console.WriteLine(valorNulo);