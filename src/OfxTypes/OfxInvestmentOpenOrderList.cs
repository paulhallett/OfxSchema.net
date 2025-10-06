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
    //         <xsd:choice minOccurs="0" maxOccurs="unbounded">
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
    
    [XmlElement("OOBUYDEBT")]                    public OfxOpenOrderBuyDebt? OOBUYDEBT { get; set; }
    [XmlElement("OOBUYMF")]                      public OfxOpenOrderBuyMutualFund? OOBUYMF { get; set; }
    [XmlElement("OOBUYOPT")]                     public OfxOpenOrderBuyOption? OOBUYOPT { get; set; }
    [XmlElement("OOBUYOTHER")]                   public OfxOpenOrderBuyOther? OOBUYOTHER { get; set; }
    [XmlElement("OOBUYSTOCK")]                   public OfxOpenOrderBuyStock? OOBUYSTOCK { get; set; }
    [XmlElement("OOSELLDEBT")]                   public OfxOpenOrderSellDebt? OOSELLDEBT { get; set; }
    [XmlElement("OOSELLMF")]                     public OfxOpenOrderSellMutualFund? OOSELLMF { get; set; }
    [XmlElement("OOSELLOPT")]                    public OfxOpenOrderSellOption? OOSELLOPT { get; set; }
    [XmlElement("OOSELLOTHER")]                  public OfxOpenOrderSellOther? OOSELLOTHER { get; set; }
    [XmlElement("OOSELLSTOCK")]                  public OfxOpenOrderSellStock? OOSELLSTOCK { get; set; }
    [XmlElement("SWITCHMF")]                     public OfxOpenOrderSwitchMutualFund? SWITCHMF { get; set; }
}
