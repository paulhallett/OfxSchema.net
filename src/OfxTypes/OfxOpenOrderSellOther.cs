// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxOpenOrderSellOther : OfxAbstractOpenOrder
{
    // <xsd:complexType name="OpenOrderSellOther">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "OOSELLOTHER" is of type "OpenOrderSellOther"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractOpenOrder" />
    //             <xsd:sequence>
    //                 <xsd:element name="UNITTYPE" type="ofx:UnitTypeEnum" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("UNITTYPE")]                     public required OfxUnitTypeEnum UNITTYPE { get; set; }
}
