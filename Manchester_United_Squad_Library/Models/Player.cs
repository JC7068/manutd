using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manchester_United_Squad_Library.Models
{
    public class Player
    { 

        [Key]
        public string? Name { get; set; }
        public string? Position { get; set; }
        public string? Nation { get; set; }
        public int Number { get; set; }
        public int Age { get; set; }
        public Stats Stats { get; set; }

        [ForeignKey("StatsId")]
        public int StatsId { get; set; }
    }

}
