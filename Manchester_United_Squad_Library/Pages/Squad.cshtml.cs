using Manchester_United_Squad_Library.Data;
using Manchester_United_Squad_Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Manchester_United_Squad_Library.Pages
{
    public class SquadModel : PageModel
    {
        private readonly ILogger<SquadModel> _logger;
        private readonly ApplicationDbContext context;
        public List<Player> Players { get; set; }
        public SquadModel(ILogger<SquadModel> logger, ApplicationDbContext Context)
        {
            _logger = logger;
            context = Context;
        }

        public void OnGet()
        {
            Players = context.Players.Select(data => data).Include(m=> m.Stats).ToList();
            
        }
    }
}