// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxStatus                          // https://schemas.liquid-technologies.com/OFX/2.1.1/status2.html
{
    [XmlElement("CODE")]                         public required OfxErrorType CODE { get; set; }
    [XmlElement("SEVERITY")]                     public required OfxSeverityEnum SEVERITY { get; set; }
    [XmlElement("MESSAGE")]                      public OfxMessageType? MESSAGE { get; set; }
}