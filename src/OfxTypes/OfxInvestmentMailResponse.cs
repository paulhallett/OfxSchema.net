// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentMailResponse
{
    // <xsd:complexType name="InvestmentMailResponse">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVMAILRS" is of type "InvestmentMailResponse"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("INVACCTFROM")]                  public required OfxInvestmentAccount INVACCTFROM { get; set; }
    [XmlElement("MAIL")]                         public required OfxMail MAIL { get; set; }
}
