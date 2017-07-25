using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica3
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleitores = 100;
            int vBrancos=50, vNulos=30, vValidos = 400;
            
            Console.Write("\n % de votos Validos: "+(vValidos * eleitores) / (vBrancos + vNulos + vValidos));
            Console.Write("\n % de votos Brancos: " + (vBrancos * eleitores) / (vBrancos + vNulos + vValidos));
            Console.Write("\n % de votos Nulos: " + (vNulos * eleitores) / (vBrancos + vNulos + vValidos));
            Console.ReadKey();
        }
    }
}
