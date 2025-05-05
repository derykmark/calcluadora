using DotNet.Operadores;

namespace DotNet.Calculadora
{
    public class CalculadoraConsole
    {
        private readonly Operacoes _operacoes;

        public CalculadoraConsole()
        {
            _operacoes = new Operacoes();
        }

        public void Iniciar()
        {
            Console.WriteLine("--------------- BEM VINDO A CALCULADORA --------------- \n");

            int opcao;
            do
            {
                MontaCabecalhoCalculadora();
                opcao = LerOpcaoUsuario();

                if (opcao > 0 && opcao <= 4)
                {
                    ExecutarOperacao(opcao);
                }
            } while (opcao != -1);
        }

        private void ExecutarOperacao(int opcaoCalculadora)
        {
            var (valor1, valor2, isValido) = MontaRequisicao();

            if (isValido)
            {
                string nomeOperacao = ObterNomeOperacao(opcaoCalculadora);
                Console.WriteLine($"------------------ {nomeOperacao.ToUpper()} ------------------ \n");
                decimal? resultado = opcaoCalculadora switch
                {
                    1 => _operacoes.Somar(valor1, valor2),
                    2 => _operacoes.Subtrair(valor1, valor2),
                    3 => _operacoes.Multiplicar(valor1, valor2),
                    4 => _operacoes.Dividir(valor1, valor2),
                    _ => null
                };

                if (resultado.HasValue)
                {
                    Console.WriteLine($"Resultado {resultado.Value}\n");
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

        private int LerOpcaoUsuario()
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

        private (decimal, decimal, bool) MontaRequisicao()
        {
            Console.WriteLine("\nInforme o Primeiro Numero:");
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

        private void MontaCabecalhoCalculadora()
        {
            Console.WriteLine("Selecione uma opcao para realizar o Calculo: \n");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Multiplicacao");
            Console.WriteLine("4 - Divisao \n");
        }

        private string ObterNomeOperacao(int opcao)
        {
            return opcao switch
            {
                1 => "Soma",
                2 => "Subtração",
                3 => "Multiplicação",
                4 => "Divisão",
                _ => "Opção Inválida"
            };
        }
    }
}