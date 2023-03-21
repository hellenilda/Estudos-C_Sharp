//using System;

namespace PrimeiroPrograma
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            /*
             * Console.WriteLine("Hello, World!");
            Console.Beep(); //Faz um Beep ao abrir o console
            */

            int x; //primeira forma de declaração
            x = 234;

            int y = 343; //segunda forma de declaração
            String nome = "Hellen";
            double altura = 1.64; //double
            bool condicao = true; //booleano
            
            Console.WriteLine(x+" e "+y);
            Console.WriteLine("Altura: "+altura);
            Console.WriteLine("Nome: "+nome);
            Console.WriteLine("Condição booleana: "+condicao);


            Console.ReadKey();
        }
    }
}