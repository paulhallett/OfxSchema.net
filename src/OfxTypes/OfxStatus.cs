// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxStatus
{
    // <xsd:complexType name="Status">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "STATUS" is of type "Status"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="CODE" type="ofx:ErrorType" />
    //         <xsd:element name="SEVERITY" type="ofx:SeverityEnum" />
    //         <xsd:element name="MESSAGE" type="ofx:MessageType" minOccurs="0" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("CODE")]                         public required OfxErrorType CODE { get; set; }
    [XmlElement("SEVERITY")]                     public required OfxSeverityEnum SEVERITY { get; set; }
    [XmlElement("MESSAGE")]                      public OfxMessageType? MESSAGE { get; set; }
}
