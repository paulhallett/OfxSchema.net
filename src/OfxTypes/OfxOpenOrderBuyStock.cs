// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxOpenOrderBuyStock : OfxAbstractOpenOrder
{
    // <xsd:complexType name="OpenOrderBuyStock">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "OOBUYSTOCK" is of type "OpenOrderBuyStock"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractOpenOrder" />
    //             <xsd:sequence>
    //                 <xsd:element name="BUYTYPE" type="ofx:BuyEnum" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("BUYTYPE")]                      public required OfxBuyEnum BUYTYPE { get; set; }
}
