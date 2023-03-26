//using System;

namespace PrimeiroPrograma
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            /*
             * Console.WriteLine("Hello, World!");
            Console.Beep(); //Faz um Beep ao abrir o 

            int x; //primeira forma de declaração
            x = 234;

            int y = 343; //segunda forma de declaração
            String nome = "Hellen";
            double altura = 1.64; //double
            bool condicao = true; //booleano
            
            Console.WriteLine(x+" e "+y);
            Console.WriteLine("Altura: "+altura);
            Console.WriteLine("Nome: "+nome);
            Console.WriteLine("Condição booleana: "+condicao
            */

            int x = 16;
            int y = -3;

            double exponenciacao = Math.Pow(x, 2);
            double raiz = Math.Sqrt(x);
            double modulo = Math.Abs(y);

            Console.WriteLine(exponenciacao);
            Console.WriteLine(raiz);
            Console.WriteLine(modulo);

            Console.ReadKey();
        }
    }
}