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
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractOpenOrder" />
    //             <xsd:sequence>
    //                 <xsd:element name="AUCTION" type="ofx:BooleanType" />
    //                 <xsd:element name="DTAUCTION" type="ofx:DateTimeType" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("AUCTION")]                      public required OfxBooleanType AUCTION { get; set; }
    [XmlElement("DTAUCTION")]                    public OfxDateTimeType? DTAUCTION { get; set; }
}
