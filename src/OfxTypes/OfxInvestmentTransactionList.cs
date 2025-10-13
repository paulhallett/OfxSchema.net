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
    //         <xsd:choice minOccurs="0" maxOccurs="unbounded">
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
    
    [XmlElement("BUYDEBT", typeof(OfxBuyDebt))]
    [XmlElement("BUYMF", typeof(OfxBuyMutualFund))]
    [XmlElement("BUYOPT", typeof(OfxBuyOption))]
    [XmlElement("BUYOTHER", typeof(OfxBuyOther))]
    [XmlElement("BUYSTOCK", typeof(OfxBuyStock))]
    [XmlElement("CLOSUREOPT", typeof(OfxClosureOption))]
    [XmlElement("INCOME", typeof(OfxIncome))]
    [XmlElement("INVEXPENSE", typeof(OfxInvestmentExpense))]
    [XmlElement("JRNLFUND", typeof(OfxJournalFund))]
    [XmlElement("JRNLSEC", typeof(OfxJournalSecurity))]
    [XmlElement("MARGININTEREST", typeof(OfxMarginInterest))]
    [XmlElement("REINVEST", typeof(OfxReinvest))]
    [XmlElement("RETOFCAP", typeof(OfxReturnOfCapital))]
    [XmlElement("SELLDEBT", typeof(OfxSellDebt))]
    [XmlElement("SELLMF", typeof(OfxSellMutualFund))]
    [XmlElement("SELLOPT", typeof(OfxSellOption))]
    [XmlElement("SELLOTHER", typeof(OfxSellOther))]
    [XmlElement("SELLSTOCK", typeof(OfxSellStock))]
    [XmlElement("SPLIT", typeof(OfxSplit))]
    [XmlElement("TRANSFER", typeof(OfxTransfer))]
    public required List<OfxAbstractInvestmentTransactionBase> ITEMS { get; set; }
    
    [XmlElement("INVBANKTRAN")]                  public List<OfxInvestmentBankTransaction>? INVBANKTRAN { get; set; }
}
