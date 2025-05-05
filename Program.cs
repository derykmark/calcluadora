using DotNet.Calculadora;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Iniciando a calculadora...");
            var calculadora = new CalculadoraConsole();
            calculadora.Iniciar();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocorreu um erro inesperado. Por favor, tente novamente mais tarde.");
            Console.WriteLine($"Detalhes do erro: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Encerrando a aplicação. Obrigado por usar a calculadora!");
        }
    }
}