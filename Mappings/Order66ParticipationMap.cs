using CsvHelper.Configuration;
using SwgohParticipation.Models;

namespace SwgohParticipation.Mappings
{
    public class Order66ParticipationMap : ClassMap<Order66Participation>
    {
        public Order66ParticipationMap()
        {
            Map(m => m.Name).Name("Name");
            Map(m => m.DiffPercent).Name("Diff Percent");
        }
    }
}