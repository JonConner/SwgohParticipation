namespace SwgohParticipation.Models
{
    public class TicketParticipation
    {
        public DateTime WeekEndDate { get; set; }
        public required string Name { get; set; }
        public required string AllyCode { get; set; }
        public int CurrentTickets { get; set; }
        public int LifetimeTickets { get; set; }
        public int? AverageTickets { get; set; }
        public int? SundayTickets { get; set; }
        public int? MondayTickets { get; set; }
        public int? TuesdayTickets { get; set; }
        public int? WednesdayTickets { get; set; }
        public int? ThursdayTickets { get; set; }
        public int? FridayTickets { get; set; }
        public int? SaturdayTickets { get; set; }
    }
}