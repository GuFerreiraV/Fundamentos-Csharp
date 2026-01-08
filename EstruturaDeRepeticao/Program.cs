Console.WriteLine("Instrução Goto e Label");
///
/// Esse laço de repeticação não é recomendado para uso em produção, devido aos seguintes problemas:
/// Código Espaguete -> O maior argumento contra o goto é que ele permite saltar para quase qualquer lugar do código, quebrando o fluxo lógico linear
/// Dificuldade de Depuração e Testes -> O uso excessivo de goto pode tornar o código difícil de seguir, depurar e testar, especialmente em programas grandes

int count = 1;

// Identificador
repeat:

Console.WriteLine($"Contador: {count}");
count++;

if (count <= 10)
    goto repeat;

Console.WriteLine("Fim do Programa!");
Console.ReadKey();