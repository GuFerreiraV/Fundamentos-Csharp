Console.WriteLine("Conversão de tipos");
int varInt = 4;
double varDouble = varInt; // Conversão implícita de int para double
Console.WriteLine(varDouble);

int numeroInt = 200000;
long numeroLong = numeroInt; // Conversão implícita de int para long
float numeroFloat = numeroInt; // Conversão implícita de int para float
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;
Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("\nConversão Explícita");
double varDouble2 = 4.5; // 8 bytes
int varInt2 = (int)varDouble2; // 4 bytes
Console.WriteLine(varInt2);

int num1 = 10;
int num2 = 3;

float resultado = (float)num1/num2;
Console.WriteLine(resultado);


int valorInt = 10;
double valorDouble = 5.5;
decimal valorDecimal = 5.231m;
float valorFloat = 3.5f;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();
string s4 = valorFloat.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.WriteLine(s4);

Console.WriteLine("-------------------------------");

Console.WriteLine(Convert.ToString(valorInt));
Console.WriteLine(Convert.ToDouble(valorInt));
Console.WriteLine(Convert.ToInt32(valorDouble));
Console.WriteLine(Convert.ToInt64(valorDouble));


Console.ReadLine();

