using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoONG
{
    public static class CsvHelperUtility
    {
        public static async Task<List<T>> LoadCsvDataAsync<T>(string path) where T : class
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"O arquivo {path} não foi encontrado.");
            }

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                MissingFieldFound = null // Ignorar campos faltantes
            }))
            {
                // Registrar o mapeamento correto
                if (typeof(T) == typeof(Doadores))
                {
                    csv.Context.RegisterClassMap<DoadoresMap>();
                }

                return await csv.GetRecordsAsync<T>().ToListAsync();
            }
        }

        public static async Task SaveCsvDataAsync<T>(string path, List<T> records) where T : class
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                await csv.WriteRecordsAsync(records);
            }
        }
    }
}
