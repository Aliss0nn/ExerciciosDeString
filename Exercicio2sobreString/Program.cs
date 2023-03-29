namespace Exercicio2sobreString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            string[] palavras = frase.Split(" ");
            int totalDePalavras = palavras.Length;

            
            Console.WriteLine();
            Console.WriteLine("O total de palavras é " + totalDePalavras);
        }

    }
}