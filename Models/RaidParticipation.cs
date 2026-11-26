namespace SwgohParticipation.Models
{
    public class RaidParticipation
    {
        public DateTime StartDate { get; set; }
        public required string Name { get; set; }
        public required string AllyCode { get; set; }
        public string Raid { get; set; } = "order66";
        public int? EstimatedScore { get; set; }
        public int? LastActualScore { get; set; }
        public int? Difference { get; set; }
        public decimal? DiffPercent { get; set; }
    }
}