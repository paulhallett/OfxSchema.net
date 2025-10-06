// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxStatementTransactionResponse : OfxAbstractTransactionResponse
{
    // <xsd:complexType name="StatementTransactionResponse">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "STMTTRNRS" is of type "StatementTransactionResponse"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractTransactionResponse" />
    //             <xsd:sequence>
    //                 <xsd:element name="OFXEXTENSION" type="ofx:OFXExtensionType" minOccurs="0" />
    //                 <xsd:element name="STMTRS" type="ofx:StatementResponse" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("STMTRS")]                       public OfxStatementResponse? STMTRS { get; set; }
}
