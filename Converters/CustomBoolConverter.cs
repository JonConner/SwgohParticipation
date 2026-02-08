using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace SwgohParticipation.Converters
{
    public class CustomBoolConverter : DefaultTypeConverter
    {
        public override object ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
        {
            if (string.IsNullOrWhiteSpace(text)) return null;

            return text.Trim().ToLower() switch
            {
                "true" or "1" or "yes" or "enabled" => true,
                "false" or "0" or "no" or "disabled" => false,
                _ => throw new Exception($"Invalid boolean value: {text}")
            };
        }
    }
}