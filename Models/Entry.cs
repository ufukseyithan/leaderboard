using System.ComponentModel.DataAnnotations;

namespace Leaderboard.Models
{
    public class Entry
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Player Name field is required."), StringLength(32, ErrorMessage = "Player Name should be less than 32 characters.")]
        public string PlayerName { get; set; }

        [Required(ErrorMessage = "Score field is required.")]
        public int Score { get; set; }

        public Entry()
        {

        }
    }
}
