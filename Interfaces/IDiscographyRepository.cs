using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GhostIrisWebApp.Models;

namespace GhostIrisWebApp.Interfaces
{
    public interface IDiscographyRepository
    {
        List<Discography> GetAllAlbums();
        List<Merch> GetAllMerch();
        Merch GetMerchItem(int id);
    }
}
