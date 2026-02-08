namespace SwgohParticipation.Models
{
    public class TwParticipation
    {
        public DateTime StartDate { get; set; }
        public required string Name { get; set; }
        public int AttackBanners { get; set; }
        public int DefenseBanners { get; set; }
        public int TotalBanners { get; set; }
        public int MinimumBanners { get; set; }
        public required string Code { get; set; }
    }
}