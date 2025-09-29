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
    // </xsd:complexType>
    
    [XmlElement("UNITTYPE")]                     public required OfxUnitTypeEnum UNITTYPE { get; set; }
}
