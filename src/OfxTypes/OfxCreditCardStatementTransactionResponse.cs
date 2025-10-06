// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxCreditCardStatementTransactionResponse : OfxAbstractTransactionResponse
{
    // <xsd:complexType name="CreditCardStatementTransactionResponse">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "CCSTMTTRNRS" is of type "CreditCardStatementTransactionResponse"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractTransactionResponse" />
    //             <xsd:sequence>
    //                 <xsd:element name="OFXEXTENSION" type="ofx:OFXExtensionType" minOccurs="0" />
    //                 <xsd:element name="CCSTMTRS" type="ofx:CreditCardStatementResponse" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("CCSTMTRS")]                     public OfxCreditCardStatementResponse? CCSTMTRS { get; set; }
}
