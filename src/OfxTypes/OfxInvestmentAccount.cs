// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentAccount : OfxAbstractAccount
{
    // <xsd:complexType name="InvestmentAccount">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "InvestmentAccount" is of type "InvestmentAccount"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("BROKERID")]                     public required OfxBrokerIdType BROKERID { get; set; }
    [XmlElement("ACCTID")]                       public required OfxAccountIdType ACCTID { get; set; }
}
