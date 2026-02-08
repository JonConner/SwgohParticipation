namespace SwgohParticipation.Models
{
    public class Order66Participation
    {
        public DateTime StartDate { get; set; }
        public required string Name { get; set; }
        public required string AllyCode { get; set; }
        public int? EstimatedScore { get; set; }
        public int? LastActualScore { get; set; }
        public int? Difference { get; set; }
        public decimal? DiffPercent { get; set; }
    }
}