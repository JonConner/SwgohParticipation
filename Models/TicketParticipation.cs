namespace SwgohParticipation.Models
{
    public class TicketParticipation
    {
        public DateTime WeekEndDate { get; set; }
        public required string Name { get; set; }
        public int DailyAverage { get; set; }
    }
}