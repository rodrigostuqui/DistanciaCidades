using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class ExecutaTestes
    {
        static void Main(string[] args)
        {
            int caminho;
            Distancia distancia = new Distancia();
            Console.WriteLine("Digite o caminho feito, para parar, digite -1");
            int.TryParse(Console.ReadLine(), out caminho);
            while (caminho != -1)
            {
                distancia.adicionaCaminho(caminho);
                int.TryParse(Console.ReadLine(), out caminho);
            }
            Console.WriteLine(distancia.distanciaCaminho());
        }
    }
}
