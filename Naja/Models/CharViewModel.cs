namespace Naja.Models;

public class CharViewModel
{
    public required External.Char Char { get; set; }
    public string? ZoneName { get; set; }
    public string? NationName { get; set; }
    public string? NationImageUrl { get; set; }
}