// ReSharper disable InconsistentNaming

namespace OfxSchema;

[XmlRoot("OFX")]
public record OfxFile
{
    [XmlElement("SIGNONMSGSRSV1")]               public required OfxSignonResponseMessageSetV1 SIGNONMSGSRSV1 { get; set; }
}