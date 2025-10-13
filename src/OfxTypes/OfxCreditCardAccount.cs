// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxCreditCardAccount : OfxAbstractAccount
{
    // <xsd:complexType name="CreditCardAccount">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX elements CCACCTFROM and CCACCTTO are of type "CreditCardAccount"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractAccount" />
    //             <xsd:sequence>
    //                 <xsd:element name="ACCTID" type="ofx:AccountIdType" />
    //                 <xsd:element name="ACCTKEY" type="ofx:AccountIdType" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("ACCTID")]                       public required OfxAccountIdType ACCTID { get; set; }
    [XmlElement("ACCTKEY")]                      public OfxAccountIdType? ACCTKEY { get; set; }
}
