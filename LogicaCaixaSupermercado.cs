using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valorCedulas = { 100, 50, 20, 10, 5, 2 };
            int valorSaque = 456;
            int nCem=0, nCinquenta=0, nVinte=0, nDez=0, nCinco=0, nDois=0;
            int valorSobra;

            do
            {
                int cedulaEscolhida = 0;
                for(int i =0; i < valorCedulas.Length;i++)
                {
                    if (valorCedulas[i] > cedulaEscolhida && valorSaque > valorCedulas[i])
                        cedulaEscolhida = valorCedulas[i];
                }
                switch(cedulaEscolhida)
                {
                    case 100:
                        {
                            nCem++;
                            break;
                        }
                    case 50:
                        {
                            nCinquenta++;
                            break;
                        }
                    case 20:
                        {
                            nVinte++;
                            break;
                        }
                    case 10:
                        {
                            nDez++;
                            break;
                        }
                    case 5:
                        {
                            nCinco++;
                            break;
                        }
                    case 2:
                        {
                            nDois++;
                            break;
                        }
                }
                valorSaque -= cedulaEscolhida;
            } while (valorSaque > 2);
            Console.Write("Você receberá: "+ nCem +" notas de cem, " + nCinquenta + " notas de cinquenta, " + nVinte + " notas de vinte, " + nDez + " notas de dez e " + nCinco +" notas de cinco!");
            Console.Write("\nsobrou: " + valorSaque + " de moedas");
            Console.ReadKey();
        }
    }
}
