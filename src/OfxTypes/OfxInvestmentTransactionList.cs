// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentTransactionList
{
    // <xsd:complexType name="InvestmentTransactionList">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVTRANLIST" is of type "InvestmentTransactionList"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("DTSTART")]                      public required OfxDateTimeType DTSTART { get; set; }
    [XmlElement("DTEND")]                        public required OfxDateTimeType DTEND { get; set; }
    [XmlElement("BUYDEBT")]                      public required OfxBuyDebt BUYDEBT { get; set; }
    [XmlElement("BUYMF")]                        public required OfxBuyMutualFund BUYMF { get; set; }
    [XmlElement("BUYOPT")]                       public required OfxBuyOption BUYOPT { get; set; }
    [XmlElement("BUYOTHER")]                     public required OfxBuyOther BUYOTHER { get; set; }
    [XmlElement("BUYSTOCK")]                     public required OfxBuyStock BUYSTOCK { get; set; }
    [XmlElement("CLOSUREOPT")]                   public required OfxClosureOption CLOSUREOPT { get; set; }
    [XmlElement("INCOME")]                       public required OfxIncome INCOME { get; set; }
    [XmlElement("INVEXPENSE")]                   public required OfxInvestmentExpense INVEXPENSE { get; set; }
    [XmlElement("JRNLFUND")]                     public required OfxJournalFund JRNLFUND { get; set; }
    [XmlElement("JRNLSEC")]                      public required OfxJournalSecurity JRNLSEC { get; set; }
    [XmlElement("MARGININTEREST")]               public required OfxMarginInterest MARGININTEREST { get; set; }
    [XmlElement("REINVEST")]                     public required OfxReinvest REINVEST { get; set; }
    [XmlElement("RETOFCAP")]                     public required OfxReturnOfCapital RETOFCAP { get; set; }
    [XmlElement("SELLDEBT")]                     public required OfxSellDebt SELLDEBT { get; set; }
    [XmlElement("SELLMF")]                       public required OfxSellMutualFund SELLMF { get; set; }
    [XmlElement("SELLOPT")]                      public required OfxSellOption SELLOPT { get; set; }
    [XmlElement("SELLOTHER")]                    public required OfxSellOther SELLOTHER { get; set; }
    [XmlElement("SELLSTOCK")]                    public required OfxSellStock SELLSTOCK { get; set; }
    [XmlElement("SPLIT")]                        public required OfxSplit SPLIT { get; set; }
    [XmlElement("TRANSFER")]                     public required OfxTransfer TRANSFER { get; set; }
    [XmlElement("INVBANKTRAN")]                  public OfxInvestmentBankTransaction? INVBANKTRAN { get; set; }
}
