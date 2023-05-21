using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> pessoa = new List<string>();

        while (true)
        {
            Console.WriteLine("Deseja cadastrar alguém? (S/N)");
            string resposta = Console.ReadLine();

            if (resposta == "S" || resposta == "s")
            {
                Console.WriteLine("Qual é o seu nome?");
                string nome = Console.ReadLine();

                if (nome != null)
                {
                    pessoa.Add(nome);
                }

            }
            else if (resposta == "N" || resposta == "n")
            {
                break;
            }
            else
            {
                Console.WriteLine("Responda com S ou N!");
            }
        }

        // Imprimir os nomes cadastrados
        Console.WriteLine("Nomes cadastrados:");
        foreach (string nome in pessoa)
        {
            Console.WriteLine(nome);
        }
    }
}