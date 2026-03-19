internal class Program
{
    private static void Main(string[] args)
    {
        //entradas
        Console.WriteLine("===Numeros Positivos y Negativos");
        int num;
        Console.WriteLine("Dame un numero entero: ");
        num = Convert.ToInt32(Console.ReadLine());
        //procesos
        //salidas
        if (num >= 0)
        {
            Console.WriteLine("Es un numero positivo");
        }
        else
        {
            Console.WriteLine("Es un numero negativo");
        }
    }
}