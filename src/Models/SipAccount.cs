using System.Text.Json.Serialization;

namespace Qexal.CTI.Models;

public class ConfigurationDto
{
    [JsonPropertyName("internalNumber")]
    public int InternalNumber { get; set; }

    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = null!;

    [JsonPropertyName("settings")]
    public string Settings { get; set; } = null!;

    [JsonPropertyName("dateTime")]
    public DateTime DateTime { get; set; }
}