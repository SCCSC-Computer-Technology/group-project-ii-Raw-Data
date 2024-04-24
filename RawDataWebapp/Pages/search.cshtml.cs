using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RawDataWebapp.Services;
using System.Collections.Generic;

namespace RawDataWebapp.Pages
{
    public class SearchModel : PageModel
    {
        public string Title { get; set; }

        private readonly SportsDbClient _sportsDbClient;

        [BindProperty]
        public string PlayerName { get; set; }

        public List<SportsDbClient.Player> Players { get; set; }

        public SearchModel(SportsDbClient sportsDbClient)
        {
            _sportsDbClient = sportsDbClient;
            Players = new List<SportsDbClient.Player>();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            ViewData["Title"] = "Search ";

            if (!string.IsNullOrEmpty(PlayerName))
            {
                Players = await _sportsDbClient.SearchPlayersByNameAsync(PlayerName);
            }
            return Page();
        }
    }
}
