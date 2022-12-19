
namespace Question1
{
    public partial class Distancia
    {
        private List<int> Caminho { get; set; } = new List<int>();
        public int distanciaCaminho()
        {
            int total = 0;
            for (int i = 0; i < this.Caminho.Count - 1; i++)
            {
                total = total + cidades[this.Caminho[i] - 1, this.Caminho[i + 1] - 1];
            }
            return total;
        }

        public void adicionaCaminho(int cidade)
        {
            if (cidade > 5 || cidade < 1)
            {
                Console.WriteLine("Cidade Inexistente");
                return;
            }
            Caminho.Add(cidade);
        }
    }
}