/*
 * 1) Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : 
 * Aluno<nome> tem<idade> anos e nota<nota> usando a concatenação e a interpolação de strings.
 */
//string name = "Paulo";
//int age = 17;
//double nota = 7.5;
//Console.WriteLine($"{name} tem {age} anos e sua nota é {nota}");

/*
 2) Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.
 */
//Console.WriteLine($"{name} \nTem {age} anos e \nSua nota é {nota}");

/*
 3- Para qual tipo de dados você pode converter um float implicitamente ?
() int
(X) double
() long
() decimal

4- Em qual conversão numérica você precisaria realizar o casting (converssão forçada) ?
() int para long
( ) double para long
(X) double para float
(X) decimal para float
(X) long para int
(X) double para decimal
 */

// 5) Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando a concatenação e também a interpolação de strings
//Console.Write("Digite a primeira letra: ");
//string letra1 = Console.ReadLine();
//Console.Write("Digite a segunda letra: ");
//string letra2 = Console.ReadLine();
//Console.Write("Digite a terceira letra: ");
//string letra3 = Console.ReadLine();

//Console.WriteLine($"{letra3}, {letra2}, {letra1}");

/*
7- Escreva um programa para receber dois valores via teclado do tipo double e a seguir
realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
exibindo o resultado: 
*/
//double valor1, valor2;
//Console.Write("valor1: ");
//valor1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("valor2: ");
//valor2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Resultados:");
//Console.WriteLine($"Soma: {valor1} + {valor2} = {valor1 + valor2}");
//Console.WriteLine($"Subtração: {valor1} - {valor2} = {valor1 - valor2}");
//Console.WriteLine($"Multiplicação: {valor1} * {valor2} = {valor1 * valor2}");
//Console.WriteLine($"Divisão: {valor1} / {valor2} = {valor1 / valor2}");

/*

8) Faça um programa para calcular o resultado da fórmula de baskara dados os valores de
a = 1 
b = 12
c = -13 
*/
//int a = 1;
//int b = 12;
//int c = -13;

//double delta = Math.Pow(b, 2) - 4 * a * c;
//double x1 = (-b+Math.Sqrt(delta))/(2 * a);
//double x2 = (-b-Math.Sqrt(delta))/(2 * a);
//Console.WriteLine($"O valor de x1 é: {x1}");
//Console.WriteLine($"O valor de x2 é: {x2}");

/*
9) Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
inválido’: (use o operador condicional ternário) */
//string nome = "admin";
//int senha = 123;
//Console.WriteLine(nome == "admin" && senha == 123 ? "Login feito com sucesso" : "Login inválido");


/*
10) Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando
a nomenclatura usada:
(V) string? nome; é um exemplo de nullable reference type;
(F) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
(V) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
(V) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
(F) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
(F) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
(V) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
(F) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
(F) Para x= 5 , a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
(F) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
(V) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?" 
*/


/*
11) Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :) 
*/
//int x, y;
//Console.Write("Digite o valor de x: ");
//x = Convert.ToInt32(Console.ReadLine());
//Console.Write("Digite o valor de y: ");
//y = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(x % 2 == 0 ? $"{x} é par" : $"{x} não é par");

/*
12- Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no
console o resultado das seguintes operações :
*/
//int valorX = 20;
//Console.WriteLine(-6 + valorX * 5); 
//Console.WriteLine((13 - 2) * valorX);
//Console.WriteLine((valorX + -2) * (20 / valorX));
//Console.WriteLine((12 + valorX) / (valorX - 4));
//Console.WriteLine(Math.Pow(valorX, 2) + valorX + 10);
//Console.WriteLine(Math.PI * Math.Pow(valorX, 2));

/*
13- Considere o seguinte trecho de código:
int y = 5 ;
y = (y++)+y+(++y); ou y = y++ + y + ++y;
Console.WriteLine(y) 
*/
//int valorY = 5;
//Console.WriteLine((valorY++)+valorY+(++valorY));

/*
14) Escreva um programa que solicite a temperatura em graus Celsius e converta para Kelvin e Farhenheit usando as fórmulas a seguir:
Converter para Kelvin => K = C + 273 ;
Converter para Farhenheit => F = (C * 9) / 5 + 32 ;
*/
double celcius;
double kelvin;
double farhenheit;
Console.WriteLine("Digite a temperatura em graus Celsius: ");
celcius = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Convertendo para kelvin: {kelvin = celcius + 273}");
Console.WriteLine($"Convertendo para farhenheit: {farhenheit = (celcius * 9) / 5 + 32}");