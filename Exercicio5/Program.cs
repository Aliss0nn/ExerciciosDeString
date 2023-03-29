using System.Resources;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     
            Console.Write("Digite uma frase: ");
         
            string frase = Console.ReadLine();
            Console.WriteLine();
            string fraseEmMaisculo = frase.ToUpper();
            string fraseEmMinusculo = frase.ToLower();                    
            string characters = frase;         
            Console.Write(characters.Length);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(fraseEmMaisculo);
            Console.WriteLine();
            Console.WriteLine(fraseEmMinusculo);
            Console.WriteLine();
            Console.Write(frase.Remove(frase.IndexOf(" ")));
            Console.WriteLine();
            int ultimoIndex = frase.Split(' ').Length;  
            string Ultimapalavra = frase.Split()[ultimoIndex - 1];
            Console.WriteLine();
            Console.WriteLine(Ultimapalavra);
                
        }
    }
}