using System.Collections.Immutable;

namespace Exercicio6
{
    internal class Program
    {
        static void MostrarCidades(string cabecalho, string[][] csvInfo)
        {


            Console.Clear();
            Console.WriteLine(cabecalho);

            for (int i = 0; i < csvInfo.Length; i++)
            {
                Console.WriteLine(string.Join(",", csvInfo[i]));
            }
            Console.ReadLine();
            Console.Clear();



        }
        static void Main(string[] args)
        {
            string csv = File.ReadAllText(@"C:\Users\alisson\Desktop\Cidades.csv").Trim();

            string[] csvArray = csv.Split('\n');
            string cabecalho = csvArray[0];
            string[][] csvInfo = new string[csvArray.Length - 1][];
            
            for (int i = 1; i < csvArray.Length; i++)
            {
                csvInfo[i - 1] = csvArray[i].Split(',');
            }

            while (true)
            {
                Console.WriteLine("1-Mostrar cidades por nomes");
                Console.WriteLine("2-Mostrar cidades por estados");
                Console.Write("Digite outro caractere para sair: ");
                string escolha = Console.ReadLine();
                if (escolha == "1")
                {
                    Array.Sort(csvInfo, (cidadeA, cidadeB) => cidadeA[2].CompareTo(cidadeB[2]));
                    MostrarCidades(cabecalho, csvInfo);
                }
                else if (escolha == "2")
                {
                    Array.Sort(csvInfo, (estadoA, estadoB) => estadoA[3].Trim().CompareTo(estadoB[3].Trim()));
                    MostrarCidades(cabecalho, csvInfo);
                }
                else
                {
                    break;
                }
            }
           




        }
    }
}