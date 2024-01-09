namespace Qexal.CTI.Models;

public class ConfigurationDto
{
    public int InternalNumber { get; set; }
    public string DisplayName { get; set; } = null!;
    public string Settings { get; set; } = null!;
    public DateTime DateTime { get; set; }
}