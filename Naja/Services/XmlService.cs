using System.Linq;
using System.Xml.Linq;

namespace Naja.Services;

public class XmlService
{
    public XDocument LoadXml(string xmlFilePath)
    {
        return XDocument.Load(xmlFilePath);
    }

    public XElement? GetElementById(XDocument doc, string elementName, string idAttributeName, ushort id)
    {
        return doc.Descendants(elementName)
                .FirstOrDefault(e =>
                {
                    XAttribute? attr = e.Attribute(idAttributeName);
                    return attr != null && ushort.TryParse(attr.Value, out ushort parsedId) && parsedId == id;
                });
    }

    public string GetAttributeValue(XElement? element, string attributeName)
    {
        if (element == null)
        {
            return string.Empty;
        }

        XAttribute? attribute = element.Attribute(attributeName);
        return attribute?.Value ?? string.Empty;
    }
}
