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
    //     <xsd:sequence>
    //         <xsd:element name="CURRATE" type="ofx:RateType" />
    //         <xsd:element name="CURSYM" type="ofx:CurrencyEnum" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("CURRATE")]                      public required OfxRateType CURRATE { get; set; }
    [XmlElement("CURSYM")]                       public required OfxCurrencyEnum CURSYM { get; set; }
}
