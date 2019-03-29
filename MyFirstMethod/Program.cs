using System;

namespace MyFirstMethod
{
    class Program
    {
        //declarar método CountTo10
        static void CountTo10()
        {
            //ciclo for que mostra o número da Count
            for(int i = 1; i <= 10; i++)
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
        }
    }
}
