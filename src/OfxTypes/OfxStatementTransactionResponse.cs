// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxStatementTransactionResponse : OfxAbstractTransactionResponse
{
    // <xsd:complexType name="StatementTransactionResponse">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "STMTTRNRS" is of type "StatementTransactionResponse"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("STMTRS")]                       public OfxStatementResponse? STMTRS { get; set; }
}
