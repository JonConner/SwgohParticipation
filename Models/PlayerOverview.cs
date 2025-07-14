namespace SwgohParticipation.Models
{
    public class PlayerOverview
    {
        public DateTime ReportDate { get; set; }
        public required string AllyCode { get; set; }
        public required string Name { get; set; }
        public string? DiscordTag { get; set; }
        public ulong DiscordId { get; set; }
        public int CharacterGP { get; set; }
        public int ShipGP { get; set; }
        public required string LeagueId { get; set; }
        public int SkillRating { get; set; }
        public decimal TotalScore { get; set; }
        public decimal ModScore { get; set; }
        public decimal GearScore { get; set; }
        public int Star7Count { get; set; }
        public int G11Count { get; set; }
        public int G12Count { get; set; }
        public int G13Count { get; set; }
        public int ZetaCount { get; set; }
        public int OmiCount { get; set; }
        public int TWOmiCount { get; set; }
        public int GACOmiCount { get; set; }
        public int TBOmiCount { get; set; }
        public int CQOmiCount { get; set; }
        public int Relic1Count { get; set; }
        public int Relic2Count { get; set; }
        public int Relic3Count { get; set; }
        public int Relic4Count { get; set; }
        public int Relic5Count { get; set; }
        public int Relic6Count { get; set; }
        public int Relic7Count { get; set; }
        public int Relic8Count { get; set; }
        public int Relic9Count { get; set; }
        public int Mod6Dot { get; set; }
        public int Speed10 { get; set; }
        public int Speed15 { get; set; }
        public int Speed20 { get; set; }
        public int Speed25 { get; set; }
        public int UltimateGLCount { get; set; }
    }
}