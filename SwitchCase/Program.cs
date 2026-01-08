Console.WriteLine("Instrução Switch");

// Método Tradicional
Console.Write("Informe a nota do aluno: ");
double nota = Convert.ToDouble(Console.ReadLine());

switch(nota)
{
    case < 5:
        Console.WriteLine("Aluno Reprovado!");
        break;
    case >= 5 and < 6:
        Console.WriteLine("Aluno em Recuperação!");
        break;
    case >= 6 and <= 9:
        Console.WriteLine("Aluno Aprovado!");
        break;
    case > 9:
        Console.WriteLine("Aluno Aprovado com Distinção!");
        break;
}
    
// Método Simplificado
string resultado = nota switch
{
    < 5 => "Aluno Reprovado!",
    >= 5 and < 6 => "Aluno em Recuperação!",
    >= 6 and <= 9 => "Aluno Aprovado!",
    > 9 => "Aluno Aprovado com Distinção!"
};
Console.WriteLine(resultado);