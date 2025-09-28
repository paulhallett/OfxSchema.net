// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxLedgerBalance
{
    [XmlElement("BALAMT")]                       public required OfxAmountType BALAMT { get; set; }
    [XmlElement("DTASOF")]                       public required OfxDateTimeType DTASOF { get; set; }
}