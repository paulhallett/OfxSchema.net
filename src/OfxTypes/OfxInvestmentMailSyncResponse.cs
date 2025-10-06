// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentMailSyncResponse : OfxAbstractSyncResponse
{
    // <xsd:complexType name="InvestmentMailSyncResponse">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVMAILSYNCRS" is of type "InvestmentMailSyncResponse"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractSyncResponse" />
    //             <xsd:sequence>
    //                 <xsd:element name="INVACCTFROM" type="ofx:InvestmentAccount" />
    //                 <xsd:element name="OFXEXTENSION" type="ofx:OFXExtensionType" minOccurs="0" />
    //                 <xsd:element name="INVMAILTRNRS" type="ofx:InvestmentMailTransactionResponse" minOccurs="0" maxOccurs="unbounded" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("INVACCTFROM")]                  public required OfxInvestmentAccount INVACCTFROM { get; set; }
    [XmlElement("INVMAILTRNRS")]                 public List<OfxInvestmentMailTransactionResponse>? INVMAILTRNRS { get; set; }
}
