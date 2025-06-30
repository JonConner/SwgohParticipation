namespace SwgohParticipation.Models
{
    public class Order66Participation
    {
        public DateTime StartDate { get; set; }
        public required string Name { get; set; }
        public decimal DiffPercent { get; set; }
    }
}