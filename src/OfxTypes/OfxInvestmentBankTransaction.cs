// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentBankTransaction
{
    // <xsd:complexType name="InvestmentBankTransaction">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVBANKTRAN" is of type "InvestmentBankTransaction"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="STMTTRN" type="ofx:StatementTransaction" />
    //         <xsd:element name="SUBACCTFUND" type="ofx:SubAccountEnum" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("STMTTRN")]                      public required OfxStatementTransaction STMTTRN { get; set; }
    [XmlElement("SUBACCTFUND")]                  public required OfxSubAccountEnum SUBACCTFUND { get; set; }
}
