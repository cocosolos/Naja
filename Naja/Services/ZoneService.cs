using System.Xml.Linq;

namespace Naja.Services;

public class ZoneService
{
    private readonly XmlService _xmlService;
    private readonly XDocument _zoneDocument;

    public ZoneService(XmlService xmlService)
    {
        _xmlService = xmlService;
        _zoneDocument = _xmlService.LoadXml("../Resources/zones.xml");
    }

    public string GetZoneName(ushort posZone)
    {
        var zoneElement = _xmlService.GetElementById(_zoneDocument, "o", "id", posZone);
        return _xmlService.GetAttributeValue(zoneElement, "en");
    }
}
