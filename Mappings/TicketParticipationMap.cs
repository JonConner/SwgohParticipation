using CsvHelper.Configuration;
using SwgohParticipation.Models;

namespace SwgohParticipation.Mappings
{
    public class TicketParticipationMap : ClassMap<TicketParticipation>
    {
        public TicketParticipationMap()
        {
            Map(m => m.Name).Name("Name");
            Map(m => m.AllyCode).Name("AllyCode").TypeConverterOption.NullValues(string.Empty);
            Map(m => m.CurrentTickets).Name("currentTickets");
            Map(m => m.LifetimeTickets).Name("lifetimeTickets").TypeConverterOption.NullValues(string.Empty);
            Map(m => m.AverageTickets).Name("averageTickets");
            Map(m => m.SundayTickets).Name("Sunday");
            Map(m => m.MondayTickets).Name("Monday");
            Map(m => m.TuesdayTickets).Name("Tuesday");
            Map(m => m.WednesdayTickets).Name("Wednesday");
            Map(m => m.ThursdayTickets).Name("Thursday");
            Map(m => m.FridayTickets).Name("Friday");
            Map(m => m.SaturdayTickets).Name("Saturday");
        }
    }
}