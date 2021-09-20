using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using GhostIrisWebApp.Models;

namespace GhostIrisWebApp.Helpers
{
    public class JsonFileReader
    {
        public static List<Discography> ReadJsonDiscography(string JsonFileName)
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<List<Discography>>(jsonFileReader.ReadToEnd());
            }
        }

        public static List<Merch> ReadJsonMerchandise(string JsonFileName)
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<List<Merch>>(jsonFileReader.ReadToEnd());
            }
        }
    }
}
