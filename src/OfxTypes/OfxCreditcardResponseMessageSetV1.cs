// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxCreditcardResponseMessageSetV1 : OfxAbstractResponseMessageSet
{
    // <xsd:complexType name="CreditcardResponseMessageSetV1">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "CREDITCARDMSGSRSV1" is of type "CreditcardResponseMessageSetV1"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("CCSTMTTRNRS")]                  public required List<OfxCreditCardStatementTransactionResponse> CCSTMTTRNRS { get; set; }
}
