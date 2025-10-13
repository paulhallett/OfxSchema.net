// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxBankAccount : OfxAbstractAccount
{
    // <xsd:complexType name="BankAccount">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX elements BANKACCTFROM and BANKACCTTO are of type "BankAccount"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractAccount" />
    //             <xsd:sequence>
    //                 <xsd:element name="BANKID" type="ofx:BankIdType" />
    //                 <xsd:element name="BRANCHID" type="ofx:AccountIdType" minOccurs="0" />
    //                 <xsd:element name="ACCTID" type="ofx:AccountIdType" />
    //                 <xsd:element name="ACCTTYPE" type="ofx:AccountEnum" />
    //                 <xsd:element name="ACCTKEY" type="ofx:AccountIdType" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("BANKID")]                       public required OfxBankIdType BANKID { get; set; }
    [XmlElement("BRANCHID")]                     public OfxAccountIdType? BRANCHID { get; set; }
    [XmlElement("ACCTID")]                       public required OfxAccountIdType ACCTID { get; set; }
    [XmlElement("ACCTTYPE")]                     public required OfxAccountEnum ACCTTYPE { get; set; }
    [XmlElement("ACCTKEY")]                      public OfxAccountIdType? ACCTKEY { get; set; }
}
