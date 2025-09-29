// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxOpenOrderSellStock : OfxAbstractOpenOrder
{
    // <xsd:complexType name="OpenOrderSellStock">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "OOSELLSTOCK" is of type "OpenOrderSellStock"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("SELLTYPE")]                     public required OfxSellTypeEnum SELLTYPE { get; set; }
}
