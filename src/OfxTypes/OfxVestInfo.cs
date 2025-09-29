// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxVestInfo
{
    // <xsd:complexType name="VestInfo">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "VESTINFO" is of type "VestInfo"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("VESTDATE")]                     public OfxDateTimeType? VESTDATE { get; set; }
    [XmlElement("VESTPCT")]                      public required OfxRateType VESTPCT { get; set; }
}
