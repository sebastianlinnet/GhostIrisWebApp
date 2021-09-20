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
    public class MerchModel : PageModel
    {
        IDiscographyRepository repo;
        public List<Merch> Merch { get; private set; }
        public MerchModel(IDiscographyRepository repository)
        {
            repo = repository;
        }
        public void OnGet()
        {
            Merch = repo.GetAllMerch();
        }
    }
}
