using System.Globalization;

namespace ExerciciosDeString
{
    internal class Program
    {
       

      

        static void Main(string[] args)
        {

            Console.Write("Digite uma frase: ");
            string fraseDigitada = Console.ReadLine();

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string titleCase = textInfo.ToTitleCase(fraseDigitada);
            Console.WriteLine();
            Console.WriteLine(titleCase);
            Console.ReadLine();

        }
    }
}