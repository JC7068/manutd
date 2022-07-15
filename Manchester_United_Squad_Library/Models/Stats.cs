using System.ComponentModel.DataAnnotations;

namespace Manchester_United_Squad_Library.Models
{
    public class Stats
    {
        [Key]
        public int StatsId { get; set; }
        public int Appearances { get; set; }
        public int Wins { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
    }
}
