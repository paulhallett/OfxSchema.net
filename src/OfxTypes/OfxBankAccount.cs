// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxBankAccount                     //  https://schemas.liquid-technologies.com/OFX/2.1.1/bankaccount.html
{
    [XmlElement("BANKID")]                       public required OfxBankIdType BANKID { get; set; }
    [XmlElement("BRANCHID")]                     public OfxAccountIdType? BRANCHID { get; set; }
    [XmlElement("ACCTID")]                       public required OfxAccountIdType ACCTID { get; set; }
    [XmlElement("ACCTTYPE")]                     public required OfxAccountEnum ACCTTYPE { get; set; }
    [XmlElement("ACCTKEY")]                      public OfxAccountIdType? ACCTKEY { get; set; }
}