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
    // </xsd:complexType>
    
    [XmlElement("BUYTYPE")]                      public required OfxBuyEnum BUYTYPE { get; set; }
}
