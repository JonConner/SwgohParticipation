using CsvHelper.Configuration;
using SwgohParticipation.Models;
using SwgohParticipation.Converters;

namespace SwgohParticipation.Mappings
{
    public class RoteParticipationMap : ClassMap<RoteParticipation>
    {
        public RoteParticipationMap()
        {
            Map(m => m.Name).Name("Name");
            Map(m => m.TotalTerritoryPoints).Name("Total Territory Points");
            Map(m => m.PlatoonUnits).Name("Platoon Units");
            Map(m => m.CombatWaves).Name("Combat Waves");
            Map(m => m.RogueActions).Name("Rogue Actions");
            Map(m => m.IsP1Deployed).Name("P1 Deployed").TypeConverter<CustomBoolConverter>();
            Map(m => m.P1TerritoryPoints).Name("P1 Territory Points");
            Map(m => m.P1DeployedGp).Name("P1 Deployed GP");
            Map(m => m.P1CombatAttempts).Name("P1 Combat Attempts");
            Map(m => m.P1SpecialAttempts).Name("P1 Special Attempts");
            Map(m => m.P1Waves).Name("P1 Waves");
            Map(m => m.IsP2Deployed).Name("P2 Deployed").TypeConverter<CustomBoolConverter>();
            Map(m => m.P2TerritoryPoints).Name("P2 Territory Points");
            Map(m => m.P2DeployedGp).Name("P2 Deployed GP");
            Map(m => m.P2CombatAttempts).Name("P2 Combat Attempts");
            Map(m => m.P2SpecialAttempts).Name("P2 Special Attempts");
            Map(m => m.P2Waves).Name("P2 Waves");
            Map(m => m.IsP3Deployed).Name("P3 Deployed").TypeConverter<CustomBoolConverter>();
            Map(m => m.P3TerritoryPoints).Name("P3 Territory Points");
            Map(m => m.P3DeployedGp).Name("P3 Deployed GP");
            Map(m => m.P3CombatAttempts).Name("P3 Combat Attempts");
            Map(m => m.P3SpecialAttempts).Name("P3 Special Attempts");
            Map(m => m.P3Waves).Name("P3 Waves");
            Map(m => m.IsP4Deployed).Name("P4 Deployed").TypeConverter<CustomBoolConverter>();
            Map(m => m.P4TerritoryPoints).Name("P4 Territory Points");
            Map(m => m.P4DeployedGp).Name("P4 Deployed GP");
            Map(m => m.P4CombatAttempts).Name("P4 Combat Attempts");
            Map(m => m.P4SpecialAttempts).Name("P4 Special Attempts");
            Map(m => m.P4Waves).Name("P4 Waves");
            Map(m => m.IsP5Deployed).Name("P5 Deployed").TypeConverter<CustomBoolConverter>();
            Map(m => m.P5TerritoryPoints).Name("P5 Territory Points");
            Map(m => m.P5DeployedGp).Name("P5 Deployed GP");
            Map(m => m.P5CombatAttempts).Name("P5 Combat Attempts");
            Map(m => m.P5SpecialAttempts).Name("P5 Special Attempts");
            Map(m => m.P5Waves).Name("P5 Waves");
            Map(m => m.IsP6Deployed).Name("P6 Deployed").TypeConverter<CustomBoolConverter>();
            Map(m => m.P6TerritoryPoints).Name("P6 Territory Points");
            Map(m => m.P6DeployedGp).Name("P6 Deployed GP");
            Map(m => m.P6CombatAttempts).Name("P6 Combat Attempts");
            Map(m => m.P6SpecialAttempts).Name("P6 Special Attempts");
            Map(m => m.P6Waves).Name("P6 Waves");
            Map(m => m.IsZeffoMissionCompleted).Name("Zeffo Mission Completed").TypeConverter<CustomBoolConverter>();
        }
    }
}