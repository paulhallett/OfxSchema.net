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
    // </xsd:complexType>
    
    [XmlElement("INVACCTFROM")]                  public required OfxInvestmentAccount INVACCTFROM { get; set; }
    [XmlElement("INVMAILTRNRS")]                 public List<OfxInvestmentMailTransactionResponse>? INVMAILTRNRS { get; set; }
}
