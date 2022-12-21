using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanciaCidades.Utils
{
    public class Utils
    {
        public static List<int> StringParaLista(string str) => str.Split(',').Select(int.Parse).ToList();
    }
}
