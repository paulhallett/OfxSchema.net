// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentMailTransactionResponse : OfxAbstractTransactionResponse
{
    // <xsd:complexType name="InvestmentMailTransactionResponse">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVMAILTRNRS" is of type "InvestmentMailTransactionResponse"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractTransactionResponse" />
    //             <xsd:sequence>
    //                 <xsd:element name="OFXEXTENSION" type="ofx:OFXExtensionType" minOccurs="0" />
    //                 <xsd:element name="INVMAILRS" type="ofx:InvestmentMailResponse" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("INVMAILRS")]                    public OfxInvestmentMailResponse? INVMAILRS { get; set; }
}
