using DotNet.Operadores;

Console.WriteLine("--------------- BEM VINDO A CALCULADORA --------------- \n");

Operacoes operacoes = new Operacoes();
int opcao;

do
{
    MontaCabecalhoCalculadora();
    opcao = LerOpcaoUsuario();

    if (opcao > 0 && opcao <= 4)
    {
        ExecutarOperacao(opcao, operacoes);
    }
} while (opcao != -1);

static void ExecutarOperacao(int opcaoCalculadora, Operacoes operacoes)
{
    var (valor1, valor2, isValido) = MontaRequisicao();

    if (isValido)
    {
        Console.WriteLine("---------------- RESULTADO ---------------- \n");
        decimal? resultado = opcaoCalculadora switch
        {
            1 => operacoes.Somar(valor1, valor2),
            2 => operacoes.Subtrair(valor1, valor2),
            3 => operacoes.Multiplicar(valor1, valor2),
            4 => operacoes.Dividir(valor1, valor2),
            _ => null
        };

        if (resultado.HasValue)
        {
            Console.WriteLine($"Resultado: {resultado.Value}\n");
        }
        else
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.\n");
        }
        Console.WriteLine("-------------------------------------------\n");
    }
    else
    {
        Console.WriteLine("Operacao nao realizada. Certifique-se de informar numeros validos.\n");
    }
}

static int LerOpcaoUsuario()
{
    while (true)
    {
        Console.WriteLine("Informe uma opcao (1-4) ou (-1 para sair):");
        string entrada = Console.ReadLine() ?? string.Empty;
        if (int.TryParse(entrada, out int opcao))
        {
            return opcao;
        }
        Console.WriteLine("Entrada invalida. Tente novamente.\n");
    }
}

static (decimal, decimal, bool) MontaRequisicao()
{
    Console.WriteLine("Informe o Primeiro Numero:");
    string valorDigitado = Console.ReadLine() ?? string.Empty;
    bool isNumero1 = decimal.TryParse(valorDigitado, out decimal valor1);

    Console.WriteLine("Informe o Segundo Numero:");
    string valorDigitado2 = Console.ReadLine() ?? string.Empty;
    bool isNumero2 = decimal.TryParse(valorDigitado2, out decimal valor2);

    Console.WriteLine("\n");

    if (!isNumero1 || !isNumero2)
    {
        Console.WriteLine("Informe numeros validos.");
        return (0, 0, false);
    }

    return (valor1, valor2, true);
}

static void MontaCabecalhoCalculadora()
{
    Console.WriteLine("Selecione uma opcao para realizar o Calculo: \n");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtracao");
    Console.WriteLine("3 - Multiplicacao");
    Console.WriteLine("4 - Divisao \n");
}