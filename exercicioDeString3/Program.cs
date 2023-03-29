namespace exercicioDeString3
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine().ToLower();
            

            string palavraCriptografada = "";
            int numero;


            for ( int i = 0;  i < palavra.Length;  i++ )
            {
                numero = Convert.ToInt32(palavra[i]) + 2;               
                palavraCriptografada += Convert.ToChar(numero);
            }
            Console.WriteLine();
            Console.WriteLine("Nova palavra:" + palavraCriptografada);

            Console.ReadLine();


        }
    }
}