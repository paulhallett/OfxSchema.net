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
    //     <xsd:sequence>
    //         <xsd:choice minOccurs="0">
    //             <xsd:element name="OOBUYDEBT" type="ofx:OpenOrderBuyDebt" />
    //             <xsd:element name="OOBUYMF" type="ofx:OpenOrderBuyMutualFund" />
    //             <xsd:element name="OOBUYOPT" type="ofx:OpenOrderBuyOption" />
    //             <xsd:element name="OOBUYOTHER" type="ofx:OpenOrderBuyOther" />
    //             <xsd:element name="OOBUYSTOCK" type="ofx:OpenOrderBuyStock" />
    //             <xsd:element name="OOSELLDEBT" type="ofx:OpenOrderSellDebt" />
    //             <xsd:element name="OOSELLMF" type="ofx:OpenOrderSellMutualFund" />
    //             <xsd:element name="OOSELLOPT" type="ofx:OpenOrderSellOption" />
    //             <xsd:element name="OOSELLOTHER" type="ofx:OpenOrderSellOther" />
    //             <xsd:element name="OOSELLSTOCK" type="ofx:OpenOrderSellStock" />
    //             <xsd:element name="SWITCHMF" type="ofx:OpenOrderSwitchMutualFund" />
    //         </xsd:choice>
    //     </xsd:sequence>
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
