using CsvHelper.Configuration;
using SwgohParticipation.Models;

namespace SwgohParticipation.Mappings
{
    public class TwParticipationMap : ClassMap<TwParticipation>
    {
        public TwParticipationMap()
        {
            Map(m => m.Name).Name("Name");
            Map(m => m.AttackBanners).Name("Attack");
            Map(m => m.DefenseBanners).Name("Defense");
            Map(m => m.TotalBanners).Name("Total");
            Map(m => m.MinimumBanners).Name("Minimum");
            Map(m => m.Code).Name("Code");
        }
    }
}