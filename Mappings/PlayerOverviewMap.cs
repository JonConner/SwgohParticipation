using CsvHelper.Configuration;
using SwgohParticipation.Models;
using SwgohParticipation.Converters;

namespace SwgohParticipation.Mappings
{
    public class PlayerOverviewMap : ClassMap<PlayerOverview>
    {
        public PlayerOverviewMap()
        {
            Map(m => m.AllyCode).Name("AllyCode");
            Map(m => m.Name).Name("Name");
            Map(m => m.DiscordTag).Name("DiscordTag");
            Map(m => m.DiscordId).Name("DiscordId");
            Map(m => m.CharacterGP).Name("CharacterGP");
            Map(m => m.ShipGP).Name("ShipGP");
            Map(m => m.LeagueId).Name("LeagueId");
            Map(m => m.SkillRating).Name("SkillRating");
            Map(m => m.TotalScore).Name("TotalScore");
            Map(m => m.ModScore).Name("ModScore");
            Map(m => m.GearScore).Name("GearScore");
            Map(m => m.Star7Count).Name("Star7Count");
            Map(m => m.G11Count).Name("G11Count");
            Map(m => m.G12Count).Name("G12Count");
            Map(m => m.G13Count).Name("G13Count");
            Map(m => m.ZetaCount).Name("ZetaCount");
            Map(m => m.OmiCount).Name("OmiCount");
            Map(m => m.TWOmiCount).Name("TWOmiCount");
            Map(m => m.GACOmiCount).Name("GACOmiCount");
            Map(m => m.TBOmiCount).Name("TBOmiCount");
            Map(m => m.CQOmiCount).Name("CQOmiCount");
            Map(m => m.Relic1Count).Name("Relic1Count");
            Map(m => m.Relic2Count).Name("Relic2Count");
            Map(m => m.Relic3Count).Name("Relic3Count");
            Map(m => m.Relic4Count).Name("Relic4Count");
            Map(m => m.Relic5Count).Name("Relic5Count");
            Map(m => m.Relic6Count).Name("Relic6Count");
            Map(m => m.Relic7Count).Name("Relic7Count");
            Map(m => m.Relic8Count).Name("Relic8Count");
            Map(m => m.Relic9Count).Name("Relic9Count");
            Map(m => m.Mod6Dot).Name("Mod6Dot");
            Map(m => m.Speed10).Name("Speed10");
            Map(m => m.Speed15).Name("Speed15");
            Map(m => m.Speed20).Name("Speed20");
            Map(m => m.Speed25).Name("Speed25");
            Map(m => m.UltimateGLCount).Name("UltimateGLCount");
        }
    }
}