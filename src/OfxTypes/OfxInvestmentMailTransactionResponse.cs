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
    // </xsd:complexType>
    
    [XmlElement("INVMAILRS")]                    public OfxInvestmentMailResponse? INVMAILRS { get; set; }
}
