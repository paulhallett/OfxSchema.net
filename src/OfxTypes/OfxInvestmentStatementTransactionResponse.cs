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
    // </xsd:complexType>
    
    [XmlElement("INVSTMTRS")]                    public OfxInvestmentStatementResponse? INVSTMTRS { get; set; }
}
