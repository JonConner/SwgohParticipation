using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace SwgohParticipation.Converters
{
    public class CustomBoolConverter : DefaultTypeConverter
    {
        public override object ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
        {
#pragma warning disable CS8603 // Possible null reference return.
            if (string.IsNullOrWhiteSpace(text)) return null;
#pragma warning restore CS8603 // Possible null reference return.

            return text.Trim().ToLower() switch
            {
                "true" or "1" or "yes" or "enabled" => true,
                "false" or "0" or "no" or "disabled" => false,
                _ => throw new Exception($"Invalid boolean value: {text}")
            };
        }
    }
}