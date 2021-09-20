using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GhostIrisWebApp.Models;
using GhostIrisWebApp.Interfaces;

namespace GhostIrisWebApp.Pages
{
    public class MusicModel : PageModel
    {
        IDiscographyRepository repo;
        [BindProperty]
        public List<Discography> Albums { get; private set; }

        public MusicModel(IDiscographyRepository repository)
        {
            repo = repository;
        }
        public void OnGet()
        {
            Albums = repo.GetAllAlbums();
        }
    }
}
