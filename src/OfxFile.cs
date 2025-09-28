// ReSharper disable InconsistentNaming

namespace OfxSchema;

[XmlRoot("OFX")]
public record OfxFile
{
    [XmlElement("SIGNONMSGSRSV1")]               public required OfxSignonResponseMessageSetV1 SIGNONMSGSRSV1 { get; set; }
    [XmlElement("BANKMSGSRSV1")]                 public OfxBankResponseMessageSetV1? BANKMSGSRSV1 { get; set; }
    [XmlElement("CREDITCARDMSGSRSV1")]           public OfxCreditcardResponseMessageSetV1? CREDITCARDMSGSRSV1 { get; set; }
}