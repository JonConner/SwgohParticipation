using CsvHelper.Configuration;
using SwgohParticipation.Models;

namespace SwgohParticipation.Mappings
{
    public class TwParticipationMap : ClassMap<TwParticipation>
    {
        public TwParticipationMap()
        {
            Map(m => m.Name).Name("Name");
            Map(m => m.Code).Name("Code");
        }
    }
}