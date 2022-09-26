namespace PavRewards.Models
{
    public class ChartInfo
    {
        public SeriesType Type { get; set; }
        public int PointChange { get; set; }
        public List<int>? Series { get; set; }
    }

    public enum SeriesType
    {
        Spending,
        Earning
    }
}