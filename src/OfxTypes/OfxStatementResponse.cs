// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxStatementResponse               //   https://schemas.liquid-technologies.com/OFX/2.1.1/?page=stmtrs.html
{
    [XmlElement("CURDEF")]                       public required OfxCurrencyEnum CURDEF { get; set; }
    [XmlElement("BANKACCTFROM")]                 public required OfxBankAccount BANKACCTFROM { get; set; }
    [XmlElement("BANKTRANLIST")]                 public OfxBankTransactionList? BANKTRANLIST { get; set; }
    [XmlElement("LEDGERBAL")]                    public required OfxLedgerBalance LEDGERBAL { get; set; }
    [XmlElement("AVAILBAL")]                     public OfxAvailableBalance? AVAILBAL { get; set; }
    [XmlElement("BALLIST")]                      public OfxBalanceList? BALLIST { get; set; }
    [XmlElement("MKTGINFO")]                     public OfxInfoType? MKTGINFO { get; set; }
}