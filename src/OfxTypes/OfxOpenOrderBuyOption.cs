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
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractOpenOrder" />
    //             <xsd:sequence>
    //                 <xsd:element name="OPTBUYTYPE" type="ofx:OptionBuyEnum" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("OPTBUYTYPE")]                   public required OfxOptionBuyEnum OPTBUYTYPE { get; set; }
}
