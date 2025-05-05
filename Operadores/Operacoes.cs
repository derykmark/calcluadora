namespace DotNet.Operadores
{
    public class Operacoes
    {

        public decimal Somar(decimal a, decimal b) => a + b;

        public decimal Subtrair(decimal a, decimal b) => a - b;

        public decimal Multiplicar(decimal a, decimal b) => a * b;

        public decimal? Dividir(decimal a, decimal b)
        {
            if (b == 0)
            {
                return null; // Retorna null para indicar erro
            }
            return a / b;
        }
    }
}