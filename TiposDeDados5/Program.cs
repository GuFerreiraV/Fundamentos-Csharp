Console.WriteLine("Struct DateTime");
DateTime dataAtual = DateTime.Now;
//Console.WriteLine(dataAtual);

DateTime dataEspecifica = new DateTime(2025, 12, 04, 4, 29, 30);
//Console.WriteLine(dataEspecifica);


DateTime hoje = DateTime.Now;
Console.WriteLine($"hoje: {hoje}\n");
// Extraindo informações de data atual
//Console.WriteLine("Dia: " + hoje.Day);
//Console.WriteLine("Mês: " + hoje.Month);
//Console.WriteLine("Ano: " + hoje.Year);
//Console.WriteLine("Hora: "+ hoje.Hour);
//Console.WriteLine("Minuto: "+ hoje.Minute);
//Console.WriteLine("Segundos: "+ hoje.Second);
//Console.WriteLine("Milissegundos: " + hoje.Millisecond);

// Adicionando Valores
Console.WriteLine("Adicionando novos valores:");
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddHours(2));
Console.WriteLine(hoje.AddYears(5));


Console.ReadKey();