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
    //             <xsd:choice>
    //                 <xsd:element name="INVSTMTTRNRS" type="ofx:InvestmentStatementTransactionResponse" />
    //                 <xsd:element name="INVMAILTRNRS" type="ofx:InvestmentMailTransactionResponse" />
    //                 <xsd:element name="INVMAILSYNCRS" type="ofx:InvestmentMailSyncResponse" />
    //                 <xsd:element name="INVSTMTENDRS" type="ofx:InvestmentStatementEndResponse" />
    //             </xsd:choice>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("INVSTMTTRNRS")]                 public OfxInvestmentStatementTransactionResponse? INVSTMTTRNRS { get; set; }
    [XmlElement("INVMAILTRNRS")]                 public OfxInvestmentMailTransactionResponse? INVMAILTRNRS { get; set; }
    [XmlElement("INVMAILSYNCRS")]                public OfxInvestmentMailSyncResponse? INVMAILSYNCRS { get; set; }
    [XmlElement("INVSTMTENDRS")]                 public OfxInvestmentStatementEndResponse? INVSTMTENDRS { get; set; }
}
