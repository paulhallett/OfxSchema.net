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
    //     <xsd:sequence>
    //         <xsd:element name="CURDEF" type="ofx:CurrencyEnum" />
    //         <xsd:element name="INVACCTFROM" type="ofx:InvestmentAccount" />
    //         <xsd:element name="INVCLOSING" type="ofx:InvestmentClosing" minOccurs="0" maxOccurs="unbounded" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("CURDEF")]                       public required OfxCurrencyEnum CURDEF { get; set; }
    [XmlElement("INVACCTFROM")]                  public required OfxInvestmentAccount INVACCTFROM { get; set; }
    [XmlElement("INVCLOSING")]                   public List<OfxInvestmentClosing>? INVCLOSING { get; set; }
}
