// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxBankResponseMessageSetV1 : OfxAbstractResponseMessageSet
{
    // <xsd:complexType name="BankResponseMessageSetV1">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "BANKMSGSRSV1" is of type "BankResponseMessageSetV1"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("STMTTRNRS")]                    public required List<OfxStatementTransactionResponse> STMTTRNRS { get; set; }
}
