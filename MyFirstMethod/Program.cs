using System;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// Prints numbers from 1 to 10, using a simple for cicle
        /// </summary>
        /// <returns>Does not return anything</returns>
        static void CountTo10()
        {
            //ciclo for que mostra o número da Count
            for (int i = 1; i <= 10; i++)
            {
                //mostrar o número da count atual
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Prints number from 1 to n, n being a variable that can be altered
        /// when calling the method
        /// </summary>
        /// <param name="n">Variable used to determine the upper limit of the
        /// count</param>
        /// <returns>Does not return anything</returns>
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

        static void CountToN(int n1, int n2)
        {
            //ciclo for que mostra o número da Count que usa os argumentos
            //dados ao chamar a função
            for (int i = n1; i <= n2; i++)
            {
                //mostrar o número da count atual
                Console.WriteLine(i);
            }
        }

        
        /// <summary>
        /// Core code inserted here, in this case the previous methods are 
        /// called inside Main
        /// </summary>
        /// <param name="args">Arguments given in the console</param>
        /// <returns>Does not return anything</returns>
        static void Main(string[] args)
        {

            //invocar método CountTo10 duas vezes
            CountTo10();
            CountTo10();

            //invocar método CountToN duas vezes com valores diferentes
            CountToN(4);
            CountToN(7);

            //invocar método CountToN duas vezes com valores de começo e fim
            //diferentes para cada
            CountToN(4, 9);
            CountToN(2, 6);
        }
    }
}
