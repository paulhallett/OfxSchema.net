// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentOpenOrderList
{
    // <xsd:complexType name="InvestmentOpenOrderList">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVOOLIST" is of type "InvestmentOpenOrderList"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("OOBUYDEBT")]                    public required OfxOpenOrderBuyDebt OOBUYDEBT { get; set; }
    [XmlElement("OOBUYMF")]                      public required OfxOpenOrderBuyMutualFund OOBUYMF { get; set; }
    [XmlElement("OOBUYOPT")]                     public required OfxOpenOrderBuyOption OOBUYOPT { get; set; }
    [XmlElement("OOBUYOTHER")]                   public required OfxOpenOrderBuyOther OOBUYOTHER { get; set; }
    [XmlElement("OOBUYSTOCK")]                   public required OfxOpenOrderBuyStock OOBUYSTOCK { get; set; }
    [XmlElement("OOSELLDEBT")]                   public required OfxOpenOrderSellDebt OOSELLDEBT { get; set; }
    [XmlElement("OOSELLMF")]                     public required OfxOpenOrderSellMutualFund OOSELLMF { get; set; }
    [XmlElement("OOSELLOPT")]                    public required OfxOpenOrderSellOption OOSELLOPT { get; set; }
    [XmlElement("OOSELLOTHER")]                  public required OfxOpenOrderSellOther OOSELLOTHER { get; set; }
    [XmlElement("OOSELLSTOCK")]                  public required OfxOpenOrderSellStock OOSELLSTOCK { get; set; }
    [XmlElement("SWITCHMF")]                     public required OfxOpenOrderSwitchMutualFund SWITCHMF { get; set; }
}
