namespace soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula valores!!");
            Console.Write("Digite um  numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{numero+numero2}");
        }
    }
}