using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GhostIrisWebApp.Models;
using GhostIrisWebApp.Interfaces;
using GhostIrisWebApp.Helpers;

namespace GhostIrisWebApp.Services
{
    public class JsonDiscographyRepository : IDiscographyRepository
    {
        string JsonDiscography = @"C:\Users\sebas\source\repos\GhostIrisWebApp\Data\jsonDiscography.json";

        string JsonMerchandise = @"C:\Users\sebas\source\repos\GhostIrisWebApp\Data\jsonMerchandise.json";
        public List<Discography> GetAllAlbums()
        {
            return JsonFileReader.ReadJsonDiscography(JsonDiscography);
        }

        public List<Merch> GetAllMerch()
        {
            return JsonFileReader.ReadJsonMerchandise(JsonMerchandise);
        }

        public Merch GetMerchItem(int id)
        {
            List<Merch> merch = GetAllMerch();
            foreach (var foundItem in merch)
            {
                if (foundItem.Id == id)
                {
                    return foundItem;
                }
            }
            return null;
        }
    }
}
