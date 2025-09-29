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
    // </xsd:complexType>
    
    [XmlElement("INVSTMTTRNRS")]                 public required OfxInvestmentStatementTransactionResponse INVSTMTTRNRS { get; set; }
    [XmlElement("INVMAILTRNRS")]                 public required OfxInvestmentMailTransactionResponse INVMAILTRNRS { get; set; }
    [XmlElement("INVMAILSYNCRS")]                public required OfxInvestmentMailSyncResponse INVMAILSYNCRS { get; set; }
    [XmlElement("INVSTMTENDRS")]                 public required OfxInvestmentStatementEndResponse INVSTMTENDRS { get; set; }
}
