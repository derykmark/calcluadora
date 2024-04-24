using DotNet.Operadores;

decimal valor1 = 0, valor2 = 0, resultado, valorInformado1, valorInformado2, opcaoCalculadora;
string operador, valorDigitado, valorDigitado2;
bool isNumero1, isNumero2;

Console.WriteLine("--------------- BEM VINDO A CALCULADORA --------------- \n");
MontaCabecalhoCalculadora();

operador = Console.ReadLine();
opcaoCalculadora = int.Parse(operador);
Operacoes operacoes = new Operacoes();
var opcao = 0;
while (opcao > -1)
{
    switch (opcaoCalculadora)
    {
        case 1:
            Console.WriteLine($"Opcao Selecionada {opcaoCalculadora}\n");
            Console.WriteLine("------------------- SOMA ------------------- \n");
            MontaRequisicao(ref valor1, ref valor2, out valorDigitado, out valorDigitado2, out isNumero1, out isNumero2);
            Console.WriteLine("RESULTADO");
            operacoes.Somar(valor1, valor2);
            Console.WriteLine("Informe (-1) para finalizar a calculadora \n");
            MontaCabecalhoCalculadora();
            opcao = int.Parse(Console.ReadLine());
            opcaoCalculadora = opcao;
            break;
        case 2:
            Console.WriteLine("\n");
            Console.WriteLine("------------------- SUBTRACAO -------------------\n");
            MontaRequisicao(ref valor1, ref valor2, out valorDigitado, out valorDigitado2, out isNumero1, out isNumero2);
            Console.WriteLine("RESULTADO");
            operacoes.Subtrair(valor1, valor2);
            Console.WriteLine("Informe (-1) para finalizar a calculadora \n");
            MontaCabecalhoCalculadora();
            opcao = int.Parse(Console.ReadLine());
            opcaoCalculadora = opcao;
            break;
        case 3:
            Console.WriteLine("\n");
            Console.WriteLine("------------------- MULTIPLICACAO -------------------\n");
            MontaRequisicao(ref valor1, ref valor2, out valorDigitado, out valorDigitado2, out isNumero1, out isNumero2);
            Console.WriteLine("RESULTADO");
            operacoes.Multiplicar(valor1, valor2);
            MontaCabecalhoCalculadora();
            Console.WriteLine("Informe (-1) para finalizar a calculadora \n");
            opcao = int.Parse(Console.ReadLine());
            opcaoCalculadora = opcao;
            break;
        case 4:
            Console.WriteLine("\n");
            Console.WriteLine("------------------- DIVISAO -------------------\n");
            MontaRequisicao(ref valor1, ref valor2, out valorDigitado, out valorDigitado2, out isNumero1, out isNumero2);
            Console.WriteLine("RESULTADO");
            operacoes.Dividir(valor1, valor2);
            Console.WriteLine("Informe (-1) para finalizar a calculadora \n");
            MontaCabecalhoCalculadora();
            opcao = int.Parse(Console.ReadLine());
            opcaoCalculadora = opcao;
            break;
        default:
            Console.WriteLine("\n");
            Console.WriteLine("Escolha uma Opcao Valida Entre 1 e 4 \n");
            opcao = int.Parse(Console.ReadLine());
            opcaoCalculadora = opcao;
            break;
    }
}

static void MontaRequisicao(ref decimal valor1, ref decimal valor2, out string valorDigitado, out string valorDigitado2, out bool isNumero1, out bool isNumero2)
{
    Console.WriteLine("Informe o Primeiro Numero:");
    valorDigitado = Console.ReadLine();
    isNumero1 = VerificaSeENumero(valorDigitado);

    if (isNumero1)
    { valor1 = decimal.Parse(valorDigitado); }
    else
        Console.WriteLine("Informe um numero");

    Console.WriteLine("Informe o Segundo Numero:");
    valorDigitado2 = Console.ReadLine();
    isNumero2 = VerificaSeENumero(valorDigitado2);
    Console.WriteLine("\n");

    if (isNumero2)
    { valor2 = decimal.Parse(valorDigitado2); }
    else
        Console.WriteLine("Informe um numero");
}
static bool VerificaSeENumero(string numero)
{
    bool verifica;
    decimal valor;
    verifica = decimal.TryParse(numero, out valor);
    return verifica;
}

static void MontaCabecalhoCalculadora()
{
    
    Console.WriteLine("Selecione uma opcao para realizar o Calculo: \n");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtracao");
    Console.WriteLine("3 - Multiplicacao");
    Console.WriteLine("4 - Divisao \n");
}



//Operacoes operacoes = new Operacoes();
//operacoes.Somar(20, 10);
//operacoes.Subtrair(20, 10);
//operacoes.Multiplicar(20, 10);
//operacoes.Dividir(20, 10);
