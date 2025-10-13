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
    
    
    [XmlElement("OOBUYDEBT", typeof(OfxOpenOrderBuyDebt))]
    [XmlElement("OOBUYMF", typeof(OfxOpenOrderBuyMutualFund))]
    [XmlElement("OOBUYOPT", typeof(OfxOpenOrderBuyOption))]
    [XmlElement("OOBUYOTHER", typeof(OfxOpenOrderBuyOther))]
    [XmlElement("OOBUYSTOCK", typeof(OfxOpenOrderBuyStock))]
    [XmlElement("OOSELLDEBT", typeof(OfxOpenOrderSellDebt))]
    [XmlElement("OOSELLMF", typeof(OfxOpenOrderSellMutualFund))]
    [XmlElement("OOSELLOPT", typeof(OfxOpenOrderSellOption))]
    [XmlElement("OOSELLOTHER", typeof(OfxOpenOrderSellOther))]
    [XmlElement("OOSELLSTOCK", typeof(OfxOpenOrderSellStock))]
    [XmlElement("SWITCHMF", typeof(OfxOpenOrderSwitchMutualFund))]
    public required List<OfxAbstractOpenOrder> ITEMS { get; set; }
    
}
