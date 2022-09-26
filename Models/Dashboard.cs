
namespace PavRewards.Models
{
    public class Dashboard
    {
        public int Balance { get; set; }
        public Card? Card { get; set; }
        public List<Transaction>? Recent { get; set; }
        public  ChartInfo? EarnedPoints { get; set; }
        public  ChartInfo? SpendPoints { get; set; }
    }
}