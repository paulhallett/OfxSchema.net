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
    // </xsd:complexType>
    
    [XmlElement("SUBACCTTO")]                    public required OfxSubAccountEnum SUBACCTTO { get; set; }
    [XmlElement("SUBACCTFROM")]                  public required OfxSubAccountEnum SUBACCTFROM { get; set; }
    [XmlElement("TOTAL")]                        public required OfxAmountType TOTAL { get; set; }
}
