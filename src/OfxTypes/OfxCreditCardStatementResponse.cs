// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxCreditCardStatementResponse
{
    // <xsd:complexType name="CreditCardStatementResponse">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "CCSTMTRS" is of type "CreditCardStatementResponse"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="CURDEF" type="ofx:CurrencyEnum" />
    //         <xsd:element name="CCACCTFROM" type="ofx:CreditCardAccount" />
    //         <xsd:element name="BANKTRANLIST" type="ofx:BankTransactionList" minOccurs="0" />
    //         <xsd:element name="BANKTRANLISTP" type="ofx:PendingTransactionList" minOccurs="0" />
    //         <xsd:element name="LEDGERBAL" type="ofx:LedgerBalance" />
    //         <xsd:element name="AVAILBAL" type="ofx:AvailableBalance" minOccurs="0" />
    //         <xsd:element name="CASHADVBALAMT" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="CASHADVAVAILAMT" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="CASHADVCREDITLIMIT" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="INTRATEPURCH" type="ofx:RateType" minOccurs="0" />
    //         <xsd:element name="INTRATECASH" type="ofx:RateType" minOccurs="0" />
    //         <xsd:element name="INTRATEXFER" type="ofx:RateType" minOccurs="0" />
    //         <xsd:element name="REWARDINFO" type="ofx:RewardInfoType" minOccurs="0" />
    //         <xsd:element name="BALLIST" type="ofx:BalanceList" minOccurs="0" />
    //         <xsd:element name="MKTGINFO" type="ofx:InfoType" minOccurs="0" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("CURDEF")]                       public required OfxCurrencyEnum CURDEF { get; set; }
    [XmlElement("CCACCTFROM")]                   public required OfxCreditCardAccount CCACCTFROM { get; set; }
    [XmlElement("BANKTRANLIST")]                 public OfxBankTransactionList? BANKTRANLIST { get; set; }
    [XmlElement("BANKTRANLISTP")]                public OfxPendingTransactionList? BANKTRANLISTP { get; set; }
    [XmlElement("LEDGERBAL")]                    public required OfxLedgerBalance LEDGERBAL { get; set; }
    [XmlElement("AVAILBAL")]                     public OfxAvailableBalance? AVAILBAL { get; set; }
    [XmlElement("CASHADVBALAMT")]                public OfxAmountType? CASHADVBALAMT { get; set; }
    [XmlElement("CASHADVAVAILAMT")]              public OfxAmountType? CASHADVAVAILAMT { get; set; }
    [XmlElement("CASHADVCREDITLIMIT")]           public OfxAmountType? CASHADVCREDITLIMIT { get; set; }
    [XmlElement("INTRATEPURCH")]                 public OfxRateType? INTRATEPURCH { get; set; }
    [XmlElement("INTRATECASH")]                  public OfxRateType? INTRATECASH { get; set; }
    [XmlElement("INTRATEXFER")]                  public OfxRateType? INTRATEXFER { get; set; }
    [XmlElement("REWARDINFO")]                   public OfxRewardInfoType? REWARDINFO { get; set; }
    [XmlElement("BALLIST")]                      public OfxBalanceList? BALLIST { get; set; }
    [XmlElement("MKTGINFO")]                     public OfxInfoType? MKTGINFO { get; set; }
}
