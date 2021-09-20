using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GhostIrisWebApp.Models
{
    public class Discography
    {
        public int Id { get; set; }
        public string AlbumCover { get; set; }
        public string AlbumTitle { get; set; }
        public string ReleaseDate { get; set; }
        public string Spotify { get; set; }
    }
}
