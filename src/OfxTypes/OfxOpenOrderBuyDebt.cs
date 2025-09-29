// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxOpenOrderBuyDebt : OfxAbstractOpenOrder
{
    // <xsd:complexType name="OpenOrderBuyDebt">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "OOBUYDEBT" is of type "OpenOrderBuyDebt"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("AUCTION")]                      public required OfxBooleanType AUCTION { get; set; }
    [XmlElement("DTAUCTION")]                    public OfxDateTimeType? DTAUCTION { get; set; }
}
