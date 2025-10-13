// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentStatementTransactionResponse : OfxAbstractTransactionResponse
{
    // <xsd:complexType name="InvestmentStatementTransactionResponse">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVSTMTTRNRS" is of type "InvestmentStatementTransactionResponse"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractTransactionResponse" />
    //             <xsd:sequence>
    //                 <xsd:element name="OFXEXTENSION" type="ofx:OFXExtensionType" minOccurs="0" />
    //                 <xsd:element name="INVSTMTRS" type="ofx:InvestmentStatementResponse" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("INVSTMTRS")]                    public OfxInvestmentStatementResponse? INVSTMTRS { get; set; }
}
