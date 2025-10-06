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
    //     <xsd:sequence>
    //         <xsd:element name="DTSTART" type="ofx:DateTimeType" />
    //         <xsd:element name="DTEND" type="ofx:DateTimeType" />
    //         <xsd:choice minOccurs="0">
    //             <xsd:element name="BUYDEBT" type="ofx:BuyDebt" />
    //             <xsd:element name="BUYMF" type="ofx:BuyMutualFund" />
    //             <xsd:element name="BUYOPT" type="ofx:BuyOption" />
    //             <xsd:element name="BUYOTHER" type="ofx:BuyOther" />
    //             <xsd:element name="BUYSTOCK" type="ofx:BuyStock" />
    //             <xsd:element name="CLOSUREOPT" type="ofx:ClosureOption" />
    //             <xsd:element name="INCOME" type="ofx:Income" />
    //             <xsd:element name="INVEXPENSE" type="ofx:InvestmentExpense" />
    //             <xsd:element name="JRNLFUND" type="ofx:JournalFund" />
    //             <xsd:element name="JRNLSEC" type="ofx:JournalSecurity" />
    //             <xsd:element name="MARGININTEREST" type="ofx:MarginInterest" />
    //             <xsd:element name="REINVEST" type="ofx:Reinvest" />
    //             <xsd:element name="RETOFCAP" type="ofx:ReturnOfCapital" />
    //             <xsd:element name="SELLDEBT" type="ofx:SellDebt" />
    //             <xsd:element name="SELLMF" type="ofx:SellMutualFund" />
    //             <xsd:element name="SELLOPT" type="ofx:SellOption" />
    //             <xsd:element name="SELLOTHER" type="ofx:SellOther" />
    //             <xsd:element name="SELLSTOCK" type="ofx:SellStock" />
    //             <xsd:element name="SPLIT" type="ofx:Split" />
    //             <xsd:element name="TRANSFER" type="ofx:Transfer" />
    //         </xsd:choice>
    //         <xsd:element name="INVBANKTRAN" type="ofx:InvestmentBankTransaction" minOccurs="0" maxOccurs="unbounded" />
    //     </xsd:sequence>
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
    [XmlElement("INVBANKTRAN")]                  public List<OfxInvestmentBankTransaction>? INVBANKTRAN { get; set; }
}
