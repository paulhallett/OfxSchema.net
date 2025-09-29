// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSecurityListTransactionResponse : OfxAbstractTransactionResponse
{
    // <xsd:complexType name="SecurityListTransactionResponse">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SECLISTTRNRS" is of type "SecurityListTransactionResponse"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("SECLISTRS")]                    public OfxEmptyType? SECLISTRS { get; set; }
}
