// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxOpenOrderSellMutualFund : OfxAbstractOpenOrder
{
    // <xsd:complexType name="OpenOrderSellMutualFund">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "OOSELLMF" is of type "OpenOrderSellMutualFund"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractOpenOrder" />
    //             <xsd:sequence>
    //                 <xsd:element name="SELLTYPE" type="ofx:SellTypeEnum" />
    //                 <xsd:element name="UNITTYPE" type="ofx:UnitTypeEnum" />
    //                 <xsd:element name="SELLALL" type="ofx:BooleanType" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("SELLTYPE")]                     public required OfxSellTypeEnum SELLTYPE { get; set; }
    [XmlElement("UNITTYPE")]                     public required OfxUnitTypeEnum UNITTYPE { get; set; }
    [XmlElement("SELLALL")]                      public required OfxBooleanType SELLALL { get; set; }
}
