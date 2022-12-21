using DistanciaCidades.Utils;
using System;


namespace Question2
{
    public class Distancia
    {
        private List<int> Caminho { get; set; } = new List<int>();

        private List<List<int>> Cidades { get; set; } = new List<List<int>>();

        public Distancia()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StreamReader sr = new StreamReader($"{desktopPath}\\matrix.txt");
            string? linha = sr.ReadLine();
            while (linha != null)
            {
                Cidades.Add(Utils.StringParaLista(linha));
                linha = sr.ReadLine();
            }
            sr = new StreamReader($"{desktopPath}\\caminho.txt");
            linha = sr.ReadLine();
            this.Caminho = Utils.StringParaLista(linha);
            this.verificaCaminho();
        }

        public void verificaCaminho()
        {
            int i = 0;
            while(i < this.Caminho.Count)
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