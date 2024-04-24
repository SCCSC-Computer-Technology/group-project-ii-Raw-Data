using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RawDataWebapp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RawDataWebapp.Pages
{
    public class WNBAModel : PageModel
    {
        private readonly AppDbContext _context;
        public bool SearchPerformed { get; set; }

        public string Title { get; set; }

        public WNBAModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        // Add SortOrder property
        [BindProperty(SupportsGet = true)]
        public string SortOrder { get; set; }

        public IList<WNBAPlayer> WNBAPlayers { get; set; } = new List<WNBAPlayer>();
        public bool LoadData { get; set; } = false;
       
        public async Task OnGetAsync()
        {
            ViewData["Title"] = "Welcome to Our WNBA Page";

            IQueryable<WNBAPlayer> playersQuery = from m in _context.WNBAPlayers select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                playersQuery = playersQuery.Where(s => s.PlayerName.Contains(SearchString) || s.TeamName.Contains(SearchString));
            }

            // Add sorting logic based on SortOrder
            switch (SortOrder)
            {
                case "PlayerName_desc":
                    playersQuery = playersQuery.OrderByDescending(s => s.PlayerName);
                    break;
                case "GamesPlayed_desc":
                    playersQuery = playersQuery.OrderByDescending(s => s.GamesPlayed);
                    break;
                case "TeamName":
                    playersQuery = playersQuery.OrderBy(s => s.TeamName);
                    break;
                case "TeamName_desc":
                    playersQuery = playersQuery.OrderByDescending(s => s.TeamName);
                    break;
                // Add more case blocks as needed for other sorts
                default:
                    playersQuery = playersQuery.OrderBy(s => s.PlayerName);
                    break;
            }

            WNBAPlayers = await playersQuery.ToListAsync();
        }
    }
}
