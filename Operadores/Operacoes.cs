namespace DotNet.Operadores
{
    public class Operacoes
    {

        public void Somar(int a, int b){
            Console.WriteLine($"{a} + {b} = {a + b}") ;
        }

        public void Subtrair(int a, int b){
            Console.WriteLine($"{a} - {b} = {a - b}") ;
        }

        public void Multiplicar(int a, int b){
            Console.WriteLine($"{a} X {b} = {a * b}") ;
        }

        public void Dividir(int a, int b){
            if( b != 0){
                Console.WriteLine($"{a} / {b} = {a / b}") ;
            }
            Console.WriteLine("Não pode ser dividido por 0");
        }
    }
}