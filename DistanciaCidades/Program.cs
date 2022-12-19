
namespace Question1
{
    public class Distancia
    {
        private List<int> Caminho { get; set; } = new List<int>();

        private List<List<int>> Cidades { get; set; } = new List<List<int>>();

        public Distancia()
        {
            StreamReader sr = new StreamReader($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\matrix.txt");
            string line = sr.ReadLine();
            while ( line != null )
            {
                Cidades.Add(Utils.StringParaLista(line));
                line = sr.ReadLine();
            }
            sr = new StreamReader($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\caminho.txt");
            line = sr.ReadLine();
            this.Caminho = Utils.StringParaLista(line);

        }
        public int distanciaCaminho()
        {
            int total = 0;
            for (int i = 0; i < this.Caminho.Count - 1; i++)
            {
                total = total + Cidades[this.Caminho[i] - 1][this.Caminho[i + 1] - 1];
            }
            return total;
        }

    }

    public class Utils
    {
        public static List<int> StringParaLista(string str)
        {
            List<int> num = new List<int>();
            int numero;
            foreach (var s in str.Split(','))
            {
                if(int.TryParse(s, out numero))
                { num.Add(numero); }
            }
            return num;
        }
    }
}