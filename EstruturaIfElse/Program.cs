Console.WriteLine("Expressão If e Else");

Console.Write("Digite a nota do aluno: ");
double nota = Convert.ToDouble(Console.ReadLine());

// Jeito tradicional
if (nota >= 6.0)
{
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Aluno reprovado!");
}


// Jeito simplificado
string resultado = (nota >= 6.0) ? "Aluno aprovado!" : "Aluno reprovado!";
Console.WriteLine(resultado);
