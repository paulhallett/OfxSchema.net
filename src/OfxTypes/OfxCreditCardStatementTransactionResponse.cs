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
    // </xsd:complexType>
    
    [XmlElement("CCSTMTRS")]                     public OfxCreditCardStatementResponse? CCSTMTRS { get; set; }
}
