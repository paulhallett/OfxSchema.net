// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxOpenOrderBuyOther : OfxAbstractOpenOrder
{
    // <xsd:complexType name="OpenOrderBuyOther">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "OOBUYOTHER" is of type "OpenOrderBuyOther"
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
