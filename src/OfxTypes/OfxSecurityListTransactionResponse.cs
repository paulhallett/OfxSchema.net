// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSecurityListTransactionResponse : OfxAbstractTransactionResponse
{
    // <xsd:complexType name="SecurityListTransactionResponse">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SECLISTTRNRS" is of type "SecurityListTransactionResponse"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractTransactionResponse" />
    //             <xsd:sequence>
    //                 <xsd:element name="OFXEXTENSION" type="ofx:OFXExtensionType" minOccurs="0" />
    //                 <xsd:element name="SECLISTRS" type="ofx:EmptyType" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("SECLISTRS")]                    public OfxEmptyType? SECLISTRS { get; set; }
}
