using CsvHelper.Configuration;
using SwgohParticipation.Models;

namespace SwgohParticipation.Mappings
{
    public class TicketParticipationMap : ClassMap<TicketParticipation>
    {
        public TicketParticipationMap()
        {
            Map(m => m.Name).Name("Name");
            Map(m => m.DailyAverage).Name("Daily Average");
        }
    }
}