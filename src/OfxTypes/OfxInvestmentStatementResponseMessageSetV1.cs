// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentStatementResponseMessageSetV1 : OfxAbstractResponseMessageSet
{
    // <xsd:complexType name="InvestmentStatementResponseMessageSetV1">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVSTMTMSGSRSV1" is of type "InvestmentStatementResponseMessageSetV1"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractResponseMessageSet" />
    //             <xsd:choice maxOccurs="unbounded">
    //                 <xsd:element name="INVSTMTTRNRS" type="ofx:InvestmentStatementTransactionResponse" />
    //                 <xsd:element name="INVMAILTRNRS" type="ofx:InvestmentMailTransactionResponse" />
    //                 <xsd:element name="INVMAILSYNCRS" type="ofx:InvestmentMailSyncResponse" />
    //                 <xsd:element name="INVSTMTENDRS" type="ofx:InvestmentStatementEndResponse" />
    //             </xsd:choice>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    
    [XmlElement("INVSTMTTRNRS", typeof(OfxInvestmentStatementTransactionResponse))]
    [XmlElement("INVMAILTRNRS", typeof(OfxInvestmentMailTransactionResponse))]
    [XmlElement("INVMAILSYNCRS", typeof(OfxInvestmentMailSyncResponse))]
    [XmlElement("INVSTMTENDRS", typeof(OfxInvestmentStatementEndResponse))]
    public required List<OfxAbstractResponse> ITEMS { get; set; }
    
}
