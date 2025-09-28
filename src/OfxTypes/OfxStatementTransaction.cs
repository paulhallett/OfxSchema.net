// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxStatementTransaction            //   https://schemas.liquid-technologies.com/OFX/2.1.1/stmttrn.html
{
    [XmlElement("TRNTYPE")]                      public required OfxTransactionEnum TRNTYPE { get; set; }
    [XmlElement("DTPOSTED")]                     public required OfxDateTimeType DTPOSTED { get; set; }
    [XmlElement("TRNAMT")]                       public required OfxAmountType TRNAMT { get; set; }
    [XmlElement("FITID")]                        public required OfxFinancialInstitutionTransactionIdType FITID { get; set; }
    [XmlElement("NAME")]                         public required OfxGenericNameType NAME { get; set; }
    [XmlElement("MEMO")]                         public OfxMessageType? MEMO { get; set; }
}