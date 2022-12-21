using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DistanciaCidades.Utils
{
    public static class Utils
    {
        public static void stringParaInt(this List<List<int>> cidades, List<string[]> strCSV)
        {
            foreach(var cid in strCSV)
            {
                var cidade = new List<int>();
                foreach (var item in cid)
                {
                    cidade.Add(int.Parse(item));
                }
                cidades.Add(cidade);
            }
        }

        public static void stringParaInt(this List<int> cidades, List<string[]> strCSV)
        {
            foreach (var cid in strCSV)
            {
                foreach (var item in cid)
                {
                    cidades.Add(int.Parse(item));
                }
            }
        }

        public static List<string[]> ReadCSV(string filepath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };

            using var reader = new StreamReader(filepath);
            using var csv = new CsvParser(reader, config);
            var listLinha = new List<string[]>();
            while(csv.Read())
            {
                var linha = csv.Record;
                listLinha.Add(linha);
            }
            return listLinha;
        }
    }
}
