// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSignonResponseMessageSetV1      // https://schemas.liquid-technologies.com/OFX/2.1.1/signonresponsemessagesetv1.html
{
    [XmlElement("SONRS")]                        public required OfxSignonResponse SONRS { get; set; }
}