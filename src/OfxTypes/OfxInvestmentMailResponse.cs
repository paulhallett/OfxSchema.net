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
    //     <xsd:sequence>
    //         <xsd:element name="INVACCTFROM" type="ofx:InvestmentAccount" />
    //         <xsd:element name="MAIL" type="ofx:Mail" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("INVACCTFROM")]                  public required OfxInvestmentAccount INVACCTFROM { get; set; }
    [XmlElement("MAIL")]                         public required OfxMail MAIL { get; set; }
}
