// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentStatementEndResponse
{
    // <xsd:complexType name="InvestmentStatementEndResponse">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVSTMTENDRS" is of type "InvestmentStatementEndResponse"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("CURDEF")]                       public required OfxCurrencyEnum CURDEF { get; set; }
    [XmlElement("INVACCTFROM")]                  public required OfxInvestmentAccount INVACCTFROM { get; set; }
    [XmlElement("INVCLOSING")]                   public OfxInvestmentClosing? INVCLOSING { get; set; }
}
