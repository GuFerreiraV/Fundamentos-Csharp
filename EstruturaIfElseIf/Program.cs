
///
/// Podemos usar instruções else if após a instrução if para avaliar mais de uma condição.
/// As instruções else if somente serão executadas se a condição na instrução if for falsa.
/// Portanto a instrução if será executada ou umas das as instruções else if será executada, mas não ambas.
///

// Maneira Tradicional
Console.Write("Informe a nota do aluno: ");
double nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("Aluno Reprovado!");
}else if (nota >= 5 && nota < 6)
{
    Console.WriteLine("Aluno em Recuperação!");
}else if (nota >=6 && nota <= 9)
{
    Console.WriteLine("Aluno Aprovado!");
}else if (nota > 9)
{
    Console.WriteLine("Aluno Aprovado com Distinção!");
}


// Maneira Simplificada
Console.Write("Informe a nota do aluno: ");
nota = Convert.ToDouble(Console.ReadLine());

string resultado = nota < 5 ? "Aluno Reprovado!" :
                   nota >= 5 && nota < 6 ? "Aluno em Recuperação!" :
                   nota >= 6 && nota <= 9 ? "Aluno Aprovado!" :
                   "Aluno Aprovado com Distinção!";
                   
Console.WriteLine(resultado);