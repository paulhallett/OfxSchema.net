// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxLedgerBalance
{
    // <xsd:complexType name="LedgerBalance">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "LEDGERBAL" is of type "LedgerBalance"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="BALAMT" type="ofx:AmountType" />
    //         <xsd:element name="DTASOF" type="ofx:DateTimeType" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("BALAMT")]                       public required OfxAmountType BALAMT { get; set; }
    [XmlElement("DTASOF")]                       public required OfxDateTimeType DTASOF { get; set; }
}
