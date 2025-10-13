// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxPendingTransactionList
{
    // <xsd:complexType name="PendingTransactionList">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "BANKTRANLISTP" is of type "PendingTransactionList"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="DTASOF" type="ofx:DateTimeType" />
    //         <xsd:element name="STMTTRNP" type="ofx:PendingTransaction" minOccurs="0" maxOccurs="unbounded" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("DTASOF")]                       public required OfxDateTimeType DTASOF { get; set; }
    [XmlElement("STMTTRNP")]                     public List<OfxPendingTransaction>? STMTTRNP { get; set; }
}
