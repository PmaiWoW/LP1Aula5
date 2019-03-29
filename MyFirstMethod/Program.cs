using System;

namespace MyFirstMethod
{
    class Program
    {
        //declarar método CountToN, dando o argumento n, que determina a count
        static void CountToN(int n)
        {
            //ciclo for que mostra o número da Count
            for (int i = 1; i <= n; i++)
            {
                //mostrar o número da count atual
                Console.WriteLine(i);
            }
        }
        
        static void Main(string[] args)
        {
            //invocar método CountToN duas vezes
            CountToN(4);
            CountToN(7);
        }
    }
}
