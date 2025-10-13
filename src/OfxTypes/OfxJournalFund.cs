// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxJournalFund : OfxAbstractInvestmentTransaction
{
    // <xsd:complexType name="JournalFund">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "JRNLFUND" is of type "JournalFund"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractInvestmentTransaction" />
    //             <xsd:sequence>
    //                 <xsd:element name="SUBACCTTO" type="ofx:SubAccountEnum" />
    //                 <xsd:element name="SUBACCTFROM" type="ofx:SubAccountEnum" />
    //                 <xsd:element name="TOTAL" type="ofx:AmountType" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("SUBACCTTO")]                    public required OfxSubAccountEnum SUBACCTTO { get; set; }
    [XmlElement("SUBACCTFROM")]                  public required OfxSubAccountEnum SUBACCTFROM { get; set; }
    [XmlElement("TOTAL")]                        public required OfxAmountType TOTAL { get; set; }
}
