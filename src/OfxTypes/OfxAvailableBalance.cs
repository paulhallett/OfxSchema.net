// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxAvailableBalance
{
    // <xsd:complexType name="AvailableBalance">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "AVAILBAL" is of type "AvailableBalance"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("BALAMT")]                       public required OfxAmountType BALAMT { get; set; }
    [XmlElement("DTASOF")]                       public required OfxDateTimeType DTASOF { get; set; }
}
