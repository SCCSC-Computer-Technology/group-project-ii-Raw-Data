using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RawDataWebapp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RawDataWebapp.Pages
{
    public class BaseballModel : PageModel
    {
        public string Title { get; set; }

        private readonly AppDbContext _context;

        public BaseballModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortOrder { get; set; }

        public IList<BaseballPlayer> BaseballPlayers { get; set; } = new List<BaseballPlayer>();
        public bool LoadData { get; set; } = false;

        public async Task OnGetAsync()
        {
            ViewData["Title"] = "Major League Baseball (MLB)";

            IQueryable<BaseballPlayer> playersQuery = from m in _context.BaseballPlayers select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                playersQuery = playersQuery.Where(s => s.PlayerName.Contains(SearchString) || s.TeamName.Contains(SearchString));
            }

            switch (SortOrder)
            {
                case "PlayerName_desc":
                    playersQuery = playersQuery.OrderByDescending(s => s.PlayerName);
                    break;
                case "GamesPlayed_desc":
                    playersQuery = playersQuery.OrderByDescending(s => s.GamesPlayed);
                    break;
                case "TeamName_desc":
                    playersQuery = playersQuery.OrderByDescending(s => s.TeamName);
                    break;
                case "PlayerName":
                    playersQuery = playersQuery.OrderBy(s => s.PlayerName);
                    break;
                // Add more sort options as needed
                default:
                    playersQuery = playersQuery.OrderBy(s => s.PlayerName); // Default sort
                    break;
            }

            BaseballPlayers = await playersQuery.ToListAsync();
        }



    }
}
