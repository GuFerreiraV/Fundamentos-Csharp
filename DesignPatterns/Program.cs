
/// <summary>
/// NET Optimized: Dependency Injection (DI)
/// 
/// No ecossistema .NET moderno, o padrão de Injeção de Dependência não é apenas um "padrão", é o coração do framework. 

/// Ele otimiza o gerenciamento de tempo de vida dos objetos e facilita testes unitários.

/// Em vez de você criar as instâncias manualmente com new, o contêiner do .NET faz isso por você.
/// </summary>

using Microsoft.Extensions.DependencyInjection;


// Configuração do Container
var services = new ServiceCollection();

// Registro dos serviços (Otimizado pelo Framework)
services.AddScoped<IMessageService, SmsAdapter>();
services.AddTransient<ExternalSmsApi>();

var serviceProvider = services.BuildServiceProvider();

// Uso: O framework resolve as dependências automaticamente
var notificationService = serviceProvider.GetRequiredService<IMessageService>();
notificationService.Send("1199999999", "DI aplicado");

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


/// <summary>
/// Structural Pattern: Adapter
///
/// O padrão Adapter é perfeito para quando você tem uma interface que o seu sistema espera, mas a biblioteca externa (ou legado) que você quer usar tem uma interface diferente.
///
/// Neste exemplo, seu sistema espera um IMessageService, mas você quer integrar um serviço de SMS de terceiros que possui métodos diferentes.
/// 
/// </summary>


// Nosso sistema espera
public interface IMessageService
{
    void Send (string receive, string content);
}

// O serviço externo que queremos integrar (incompatível)
public class ExternalSmsApi
{
    public void ExecuteSendSms(string phone, string text)
    {
        Console.WriteLine($"SMS enviado para {phone}: {text}");
    }
}

// O Adapter irá fazer a ponte entre o serviço externo e o sistema
public class SmsAdapter : IMessageService
{
    private readonly ExternalSmsApi _externalSmsApi;

    public SmsAdapter(ExternalSmsApi externalSmsApi)
    {
        _externalSmsApi = externalSmsApi;
    }
 
    public void Send (string receive, string content)
    {
        _externalSmsApi.ExecuteSendSms(receive, content);
    }
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/// <summary>
/// Real-World Pattern: Strategy
/// 
/// O Strategy é um dos padrões mais usados no dia a dia. 
/// Ele permite que você mude o comportamento de um objeto em tempo de execução. 
/// Imagine que seu sistema de mercado precisa calcular o frete de formas diferentes.
/// </summary>

public interface IShippingStrategy 
{
    decimal Calculate (decimal weight);        
}

public class ExpressShipping : IShippingStrategy
{
    public decimal Calculate (decimal weight) => weight * 5.0m;
}

public class StandartShipping : IShippingStrategy
{
    public decimal Calculate (decimal weight) => weight * 2.5m;
}

public class Order
{
    // agora a variavel armazena o calculo de ExpressShipping e StandardShipping --> Exemplo: _shippingStrategy = new ExpressShipping() 
    private IShippingStrategy _shippingStrategy;

    public Order (IShippingStrategy shippingStrategy)
    {
        _shippingStrategy = shippingStrategy;
    }

    public void SetShippingStrategy(IShippingStrategy shippingStrategy)
    {
        _shippingStrategy = shippingStrategy;
    }

    public decimal CaculateTotalShipping(decimal weight)
    {
        return _shippingStrategy.Calculate(weight);
    }
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



