// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxStatementResponse
{
    // <xsd:complexType name="StatementResponse">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "STMTRS" is of type "StatementResponse"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="CURDEF" type="ofx:CurrencyEnum" />
    //         <xsd:element name="BANKACCTFROM" type="ofx:BankAccount" />
    //         <xsd:element name="BANKTRANLIST" type="ofx:BankTransactionList" minOccurs="0" />
    //         <xsd:element name="BANKTRANLISTP" type="ofx:PendingTransactionList" minOccurs="0" />
    //         <xsd:element name="LEDGERBAL" type="ofx:LedgerBalance" />
    //         <xsd:element name="AVAILBAL" type="ofx:AvailableBalance" minOccurs="0" />
    //         <xsd:element name="CASHADVBALAMT" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="INTRATE" type="ofx:RateType" minOccurs="0" />
    //         <xsd:element name="BALLIST" type="ofx:BalanceList" minOccurs="0" />
    //         <xsd:element name="MKTGINFO" type="ofx:InfoType" minOccurs="0" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("CURDEF")]                       public required OfxCurrencyEnum CURDEF { get; set; }
    [XmlElement("BANKACCTFROM")]                 public required OfxBankAccount BANKACCTFROM { get; set; }
    [XmlElement("BANKTRANLIST")]                 public OfxBankTransactionList? BANKTRANLIST { get; set; }
    [XmlElement("BANKTRANLISTP")]                public OfxPendingTransactionList? BANKTRANLISTP { get; set; }
    [XmlElement("LEDGERBAL")]                    public required OfxLedgerBalance LEDGERBAL { get; set; }
    [XmlElement("AVAILBAL")]                     public OfxAvailableBalance? AVAILBAL { get; set; }
    [XmlElement("CASHADVBALAMT")]                public OfxAmountType? CASHADVBALAMT { get; set; }
    [XmlElement("INTRATE")]                      public OfxRateType? INTRATE { get; set; }
    [XmlElement("BALLIST")]                      public OfxBalanceList? BALLIST { get; set; }
    [XmlElement("MKTGINFO")]                     public OfxInfoType? MKTGINFO { get; set; }
}
