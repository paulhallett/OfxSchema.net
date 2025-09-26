// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSignonResponse                  // https://schemas.liquid-technologies.com/OFX/2.1.1/sonrs.html
{
    [XmlElement("STATUS")]                       public required OfxStatus STATUS { get; set; }
    [XmlElement("DTSERVER")]                     public required OfxDateTimeType DTSERVER { get; set; }
    [XmlElement("LANGUAGE")]                     public required OfxLanguageEnum LANGUAGE { get; set; }
    [XmlElement("DTPROFUP")]                     public OfxDateTimeType? DTPROFUP { get; set; }
    [XmlElement("DTACCTUP")]                     public OfxDateTimeType? DTACCTUP { get; set; }
}