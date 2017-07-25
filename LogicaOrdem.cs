using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = { 1, 5, 3, 4, 2, 7, 6, 8, 10, 9 };
            int cont2, aux;

            for (int i = 0; i < 10; i++)
            {
                for (cont2 = 0; cont2 < 9; cont2++)
                {
                    if (valores[cont2] > valores[cont2 + 1])
                    {
                        aux = valores[cont2];
                        valores[cont2] = valores[cont2 + 1];
                        valores[cont2 + 1] = aux;
                    }
                }
            }
            foreach(int it in valores)
            {
                Console.Write(it);
            }
            Console.ReadKey();
        }
        
    }
}
