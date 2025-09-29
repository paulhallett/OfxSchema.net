// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxOpenOrderSellOption : OfxAbstractOpenOrder
{
    // <xsd:complexType name="OpenOrderSellOption">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "OOSELLOPT" is of type "OpenOrderSellOption"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("OPTSELLTYPE")]                  public required OfxOptionSellEnum OPTSELLTYPE { get; set; }
}
