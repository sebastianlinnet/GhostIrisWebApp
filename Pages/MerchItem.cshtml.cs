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
    public class MerchItemModel : PageModel
    {
        IDiscographyRepository repo;
        public Merch Merch { get; private set; }
        public MerchItemModel(IDiscographyRepository repository)
        {
            repo = repository;
        }
        public void OnGet(int id)
        {
            Merch = repo.GetMerchItem(id);
        }
    }
}
