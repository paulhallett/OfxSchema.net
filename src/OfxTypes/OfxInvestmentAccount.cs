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
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractAccount" />
    //             <xsd:sequence>
    //                 <xsd:element name="BROKERID" type="ofx:BrokerIdType" />
    //                 <xsd:element name="ACCTID" type="ofx:AccountIdType" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("BROKERID")]                     public required OfxBrokerIdType BROKERID { get; set; }
    [XmlElement("ACCTID")]                       public required OfxAccountIdType ACCTID { get; set; }
}
