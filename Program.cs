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
    decimal valor1 = 0, valor2 = 0;
    string valorDigitado, valorDigitado2;
    bool isNumero1, isNumero2;

    switch (opcaoCalculadora)
    {
        case 1:
            Console.WriteLine("------------------- SOMA ------------------- \n");
            break;
        case 2:
            Console.WriteLine("------------------- SUBTRACAO ------------------- \n");
            break;
        case 3:
            Console.WriteLine("------------------- MULTIPLICACAO ------------------- \n");
            break;
        case 4:
            Console.WriteLine("------------------- DIVISAO ------------------- \n");
            break;
        default:
            Console.WriteLine("Opcao invalida. Escolha entre 1 e 4.\n");
            return;
    }

    MontaRequisicao(ref valor1, ref valor2, out valorDigitado, out valorDigitado2, out isNumero1, out isNumero2);

    if (isNumero1 && isNumero2)
    {
        Console.WriteLine("RESULTADO");
        switch (opcaoCalculadora)
        {
            case 1: operacoes.Somar(valor1, valor2); break;
            case 2: operacoes.Subtrair(valor1, valor2); break;
            case 3: operacoes.Multiplicar(valor1, valor2); break;
            case 4: operacoes.Dividir(valor1, valor2); break;
        }
    }
    else
    {
        Console.WriteLine("Operacao nao realizada. Certifique-se de informar numeros validos.\n");
    }
}

static int LerOpcaoUsuario()
{
    int opcao;
    while (true)
    {
        Console.WriteLine("Informe uma opcao (1-4) ou (-1 para sair):");
        string entrada = Console.ReadLine();
        if (int.TryParse(entrada, out opcao))
        {
            return opcao;
        }
        Console.WriteLine("Entrada invalida. Tente novamente.\n");
    }
}

static void MontaRequisicao(ref decimal valor1, ref decimal valor2, out string valorDigitado, out string valorDigitado2, out bool isNumero1, out bool isNumero2)
{
    Console.WriteLine("Informe o Primeiro Numero:");
    valorDigitado = Console.ReadLine();
    isNumero1 = VerificaSeENumero(valorDigitado);

    if (isNumero1)
    {
        valor1 = decimal.Parse(valorDigitado);
    }
    else
    {
        Console.WriteLine("Informe um numero valido.");
    }

    Console.WriteLine("Informe o Segundo Numero:");
    valorDigitado2 = Console.ReadLine();
    isNumero2 = VerificaSeENumero(valorDigitado2);
    Console.WriteLine("\n");

    if (isNumero2)
    {
        valor2 = decimal.Parse(valorDigitado2);
    }
    else
    {
        Console.WriteLine("Informe um numero valido.");
    }
}

static bool VerificaSeENumero(string numero)
{
    return decimal.TryParse(numero, out _);
}

static void MontaCabecalhoCalculadora()
{
    Console.WriteLine("Selecione uma opcao para realizar o Calculo: \n");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtracao");
    Console.WriteLine("3 - Multiplicacao");
    Console.WriteLine("4 - Divisao \n");
}