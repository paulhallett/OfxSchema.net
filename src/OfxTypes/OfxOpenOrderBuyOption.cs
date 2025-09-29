// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxOpenOrderBuyOption : OfxAbstractOpenOrder
{
    // <xsd:complexType name="OpenOrderBuyOption">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "OOBUYOPT" is of type "OpenOrderBuyOption"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("OPTBUYTYPE")]                   public required OfxOptionBuyEnum OPTBUYTYPE { get; set; }
}
