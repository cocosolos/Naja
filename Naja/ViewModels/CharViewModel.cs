namespace Naja.ViewModels;

public class CharViewModel
{
    public required Models.External.Char Character { get; set; }
    public string? ZoneName { get; set; }
    public string? NationName { get; set; }
    public string? NationImageUrl { get; set; }
    public uint? Gil { get; set; }
}