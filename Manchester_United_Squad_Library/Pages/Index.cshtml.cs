using Manchester_United_Squad_Library.Data;
using Manchester_United_Squad_Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Manchester_United_Squad_Library.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        public string? RequestId { get; set; }

        private readonly ApplicationDbContext _context;

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            SeedData();
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }

        protected  void SeedData()
        {

            if(_context.Players.Count() > 0) { return;  }

                _context.Players.AddRange(
                new Player
                {
                    Position = "GK",
                    Number = 1,
                    Name = "David De Gea",
                    Age = 31,
                    Nation = "Spain",
                    StatsId = 24,

                    Stats = new Stats
                    {
                        StatsId = 24,
                        Appearances = 377,
                        Wins = 202,
                        Goals = 0,
                        Assists = 0,
                    }
                },
                new Player
                {
                    Position = "GK",
                    Number = 26,
                    Name = "Dean Henderson",
                    Age = 25,
                    Nation = "England",
                    StatsId = 1,

                    Stats = new Stats
                    {
                        StatsId = 1,
                        Appearances = 27,
                        Wins = 11,
                        Goals = 0,
                        Assists = 0,
                    }
                },

                new Player
                {
                    Position = "LB",
                    Number = 27,
                    Name = "Alex Telles",
                    Age = 29,
                    Nation = "Brazil",
                    StatsId = 2,

                    Stats = new Stats
                    {
                        StatsId = 2,
                        Appearances = 30,
                        Wins = 16,
                        Goals = 0,
                        Assists = 6,
                    }
                },

                new Player
                {
                    Position = "LB",
                    Number = 33,
                    Name = "Brandon Williams",
                    Age = 21,
                    Nation = "England",
                    StatsId = 3,

                    Stats = new Stats
                    {
                        StatsId = 3,
                        Appearances = 47,
                        Wins = 16,
                        Goals = 1,
                        Assists = 1,
                    }
                },

                new Player
                {
                    Position = "LB",
                    Number = 23,
                    Name = "Luke Shaw",
                    Age = 27,
                    Nation = "England",
                    StatsId = 4,

                    Stats = new Stats
                    {
                        StatsId = 4,
                        Appearances = 208,
                        Wins = 92,
                        Goals = 2,
                        Assists = 15,
                    }
                },

                new Player
                {
                    Position = "CB",
                    Number = 3,
                    Name = "Eric Bailly",
                    Age = 28,
                    Nation = "Ivory Coast",
                    StatsId = 5,

                    Stats = new Stats
                    {
                        StatsId = 5,
                        Appearances = 70,
                        Wins = 44,
                        Goals = 1,
                        Assists = 0,
                    }
                },

                new Player
                {
                    Position = "CB",
                    Number = 5,
                    Name = "Harry Maguire",
                    Age = 29,
                    Nation = "England",
                    StatsId = 6,

                    Stats = new Stats
                    {
                        StatsId = 6,
                        Appearances = 203,
                        Wins = 85,
                        Goals = 11,
                        Assists = 8,
                    }
                },

                new Player
                {
                    Position = "CB",
                    Number = 4,
                    Name = "Phil Jones",
                    Age = 30,
                    Nation = "England",
                    StatsId = 7,

                    Stats = new Stats
                    {
                        StatsId = 7,
                        Appearances = 204,
                        Wins = 105,
                        Goals = 2,
                        Assists = 6,
                    }
                },

                new Player
                {
                    Position = "CB",
                    Number = 19,
                    Name = "Raphael Varane",
                    Age = 29,
                    Nation = "France",
                    StatsId = 8,

                    Stats = new Stats
                    {
                        StatsId = 8,
                        Appearances = 22,
                        Wins = 10,
                        Goals = 1,
                        Assists = 1,
                    }
                },

                new Player
                {
                    Position = "CB",
                    Number = 2,
                    Name = "Victor Lindelof",
                    Age = 27,
                    Nation = "Sweden",
                    StatsId = 9,

                    Stats = new Stats
                    {
                        StatsId = 9,
                        Appearances = 139,
                        Wins = 68,
                        Goals = 3,
                        Assists = 4,
                    }
                },

                new Player
                {
                    Position = "RB",
                    Number = 29,
                    Name = "Aaron Wan-Bissaka",
                    Age = 24,
                    Nation = "England",
                    StatsId = 10,

                    Stats = new Stats
                    {
                        StatsId = 10,
                        Appearances = 131,
                        Wins = 59,
                        Goals = 2,
                        Assists = 11,
                    }
                },

                new Player
                {
                    Position = "RB",
                    Number = 20,
                    Name = "Diogo Dalot",
                    Age = 23,
                    Nation = "Portugal",
                    StatsId = 11,

                    Stats = new Stats
                    {
                        StatsId = 11,
                        Appearances = 44,
                        Wins = 20,
                        Goals = 0,
                        Assists = 2,
                    }
                },

                new Player
                {
                    Position = "CM",
                    Number = 8,
                    Name = "Bruno Fernandes",
                    Age = 27,
                    Nation = "Portugal",
                    StatsId = 12,

                    Stats = new Stats
                    {
                        StatsId = 12,
                        Appearances = 87,
                        Wins = 43,
                        Goals = 36,
                        Assists = 25,
                    }
                },

                new Player
                {
                    Position = "CM",
                    Number = 34,
                    Name = "Donny Van de Beek",
                    Age = 25,
                    Nation = "Netherlands",
                    StatsId = 13,

                    Stats = new Stats
                    {
                        StatsId = 13,
                        Appearances = 34,
                        Wins = 16,
                        Goals = 3,
                        Assists = 1,
                    }
                },

                new Player
                {
                    Position = "CM",
                    Number = 17,
                    Name = "Fred",
                    Age = 29,
                    Nation = "Brazil",
                    StatsId = 14,

                    Stats = new Stats
                    {
                        StatsId = 14,
                        Appearances = 104,
                        Wins = 52,
                        Goals = 6,
                        Assists = 5,
                    }
                },

                new Player
                {
                    Position = "CM",
                    Number = 46,
                    Name = "Hannibal",
                    Age = 19,
                    Nation = "Tunisia",
                    StatsId = 15,

                    Stats = new Stats
                    {
                        StatsId = 15,
                        Appearances = 3,
                        Wins = 1,
                        Goals = 0,
                        Assists = 0,
                    }
                },

                new Player
                {
                    Position = "CM",
                    Number = 39,
                    Name = "Scott McTominay",
                    Age = 25,
                    Nation = "Scotland",
                    StatsId = 16,

                    Stats = new Stats
                    {
                        StatsId = 16,
                        Appearances = 120,
                        Wins = 62,
                        Goals = 11,
                        Assists = 3,
                    }
                },

                new Player
                {
                    Position = "RW",
                    Number = 39,
                    Name = "Anthony Elanga",
                    Age = 25,
                    Nation = "Sweden",
                    StatsId = 17,

                    Stats = new Stats
                    {
                        StatsId = 17,
                        Appearances = 23,
                        Wins = 9,
                        Goals = 3,
                        Assists = 2,
                    }
                },

                new Player
                {
                    Position = "RW",
                    Number = 25,
                    Name = "Jadon Sancho",
                    Age = 22,
                    Nation = "England",
                    StatsId = 18,

                    Stats = new Stats
                    {
                        StatsId = 18,
                        Appearances = 29,
                        Wins = 12,
                        Goals = 3,
                        Assists = 3,
                    }
                },

                new Player
                {
                    Position = "LW",
                    Number = 10,
                    Name = "Marcus Rashford",
                    Age = 24,
                    Nation = "England",
                    StatsId = 19,

                    Stats = new Stats
                    {
                        StatsId = 19,
                        Appearances = 204,
                        Wins = 105,
                        Goals = 59,
                        Assists = 32,
                    }
                },

                new Player
                {
                    Position = "LW",
                    Number = 44,
                    Name = "Tahith Chong",
                    Age = 22,
                    Nation = "Netherlands",
                    StatsId = 20,

                    Stats = new Stats
                    {
                        StatsId = 20,
                        Appearances = 5,
                        Wins = 3,
                        Goals = 0,
                        Assists = 0,
                    }
                },

                new Player
                {
                    Position = "ST",
                    Number = 9,
                    Name = "Anthony Martial",
                    Age = 26,
                    Nation = "France",
                    StatsId = 21,

                    Stats = new Stats
                    {
                        StatsId = 21,
                        Appearances = 175,
                        Wins = 91,
                        Goals = 56,
                        Assists = 26,
                    }
                },

                new Player
                {
                    Position = "ST",
                    Number = 7,
                    Name = "Cristiano Ronaldo",
                    Age = 37,
                    Nation = "Portugal",
                    StatsId = 22,

                    Stats = new Stats
                    {
                        StatsId = 22,
                        Appearances = 226,
                        Wins = 146,
                        Goals = 102,
                        Assists = 37,
                    }
                }
            );
            _context.SaveChanges();
        }
    }
}