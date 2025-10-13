// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSecurityListResponseMessageSetV1 : OfxAbstractResponseMessageSet
{
    // <xsd:complexType name="SecurityListResponseMessageSetV1">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SECLISTMSGSRSV1" is of type "SecurityListResponseMessageSetV1"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractResponseMessageSet" />
    //             <xsd:sequence>
    //                 <xsd:element name="SECLISTTRNRS" type="ofx:SecurityListTransactionResponse" minOccurs="0" maxOccurs="unbounded" />
    //                 <xsd:element name="SECLIST" type="ofx:SecurityList" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("SECLISTTRNRS")]                 public List<OfxSecurityListTransactionResponse>? SECLISTTRNRS { get; set; }
    [XmlElement("SECLIST")]                      public OfxSecurityList? SECLIST { get; set; }
}
