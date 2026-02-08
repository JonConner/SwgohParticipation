using CsvHelper.Configuration;
using SwgohParticipation.Models;
using SwgohParticipation.Converters;

namespace SwgohParticipation.Mappings
{
    public class Order66ParticipationMap : ClassMap<Order66Participation>
    {
        public Order66ParticipationMap()
        {
            Map(m => m.Name).Name("name");
            Map(m => m.AllyCode).Name("allycode");
            Map(m => m.EstimatedScore).Name("estimatedScore");
            Map(m => m.LastActualScore).Name("lastActualScore");
            Map(m => m.Difference).Name("diff");
            Map(m => m.DiffPercent).Name("diffPercent");
        }
    }
}