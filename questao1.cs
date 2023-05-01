using System;

namespace q_1
{
    public static class Program
    {
        public static void Main()
        {
        int x, y;
        do
        {
            Console.Write("Insira um numero a ser verificado:");
            x = int.Parse(Console.ReadLine());
            Console.Write("Insira outro numero a ser verificado:");
            y = int.Parse(Console.ReadLine());
            Console.Clear();
        } while (x == y);
        if (y % x == 0)
        {
            Console.WriteLine("Caso A");
        }
        else if ( x % y == 0 {
            Console.WriteLine("Caso B");
        }
        else
            Console.WriteLine("Caso C")


        Console.ReadKey();  
        }
    }
}