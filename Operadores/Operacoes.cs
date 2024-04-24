namespace DotNet.Operadores
{
    public class Operacoes
    {

        public void Somar(decimal a, decimal b){
            Console.WriteLine($"{a} + {b} = {a + b} \n") ;
        }

        public void Subtrair(decimal a, decimal b){
            Console.WriteLine($"{a} - {b} = {a - b} \n") ;
        }

        public void Multiplicar(decimal a, decimal b){
            Console.WriteLine($"{a} X {b} = {a * b} \n") ;
        }

        public void Dividir(decimal a, decimal b){
            if( b != 0){
                Console.WriteLine($"{a} / {b} = {a / b}  \n") ;
            }
            Console.WriteLine("Não pode ser dividido por 0");
        }
    }
}