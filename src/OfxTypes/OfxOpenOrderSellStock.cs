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
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractOpenOrder" />
    //             <xsd:sequence>
    //                 <xsd:element name="SELLTYPE" type="ofx:SellTypeEnum" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("SELLTYPE")]                     public required OfxSellTypeEnum SELLTYPE { get; set; }
}
