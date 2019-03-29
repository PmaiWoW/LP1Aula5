using System;

namespace MyFirstMethod
{
    class Program
    {

        //declarar método CountTo10
        static void CountTo10()
        {
            //ciclo for que mostra o número da Count
            for (int i = 1; i <= 10; i++)
            {
                //mostrar o número da count atual
                Console.WriteLine(i);
            }
        }


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

            //invocar método CountTo10 duas vezes
            CountTo10();
            CountTo10();

            //invocar método CountToN duas vezes com valores diferentes
            CountToN(4);
            CountToN(7);
        }
    }
}
