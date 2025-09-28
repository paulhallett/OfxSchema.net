// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxBankTransactionList             //   https://schemas.liquid-technologies.com/OFX/2.1.1/banktranlist.html
{
    [XmlElement("DTSTART")]                      public required OfxDateTimeType DTSTART { get; set; }
    [XmlElement("DTEND")]                        public required OfxDateTimeType DTEND { get; set; }
    [XmlElement("STMTTRN")]                      public List<OfxStatementTransaction>? STMTTRN { get; set; }
}