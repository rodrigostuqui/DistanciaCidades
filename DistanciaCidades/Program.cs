using DistanciaCidades.Utils;

namespace Question1
{
    public class Distancia
    {
        private List<int> Caminho { get; set; } = new List<int>();

        private List<List<int>> Cidades { get; set; } = new List<List<int>>();

        public Distancia()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var cidade = Utils.ReadCSV($"{desktopPath}\\matrix.txt");
            this.Cidades.stringParaInt(cidade);
            var caminho = Utils.ReadCSV($"{desktopPath}\\caminho.txt");
            this.Caminho.stringParaInt(caminho);
            this.verificaCaminho();
        }
        private void verificaCaminho()
        {
            int i = 0;
            while (i < this.Caminho.Count)
            {
                if (this.Caminho[i] > this.Cidades.Count || this.Caminho[i] < 0)
                {
                    Console.WriteLine($"Cidade {this.Caminho[i]} inexistente, removendo-a");
                    this.Caminho.RemoveAt(i);
                    continue;
                }
                i++;
            }
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
}