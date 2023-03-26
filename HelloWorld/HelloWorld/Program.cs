namespace PrimeiroPrograma
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual sua idade? ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é de maior!");
            }
            else
            {
                Console.WriteLine("Você é menor de idade!");
            }

            Console.ReadKey();
        }
    }
}