// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxCurrency
{
    // <xsd:complexType name="Currency">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX elements "ORIGCURRENCY" and  "CURRENCY" is of type "Currency"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("CURRATE")]                      public required OfxRateType CURRATE { get; set; }
    [XmlElement("CURSYM")]                       public required OfxCurrencyEnum CURSYM { get; set; }
}
