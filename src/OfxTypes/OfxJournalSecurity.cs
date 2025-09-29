// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxJournalSecurity : OfxAbstractInvestmentTransaction
{
    // <xsd:complexType name="JournalSecurity">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "JRNLSEC" is of type "JournalSecurity"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("SECID")]                        public required OfxSecurityId SECID { get; set; }
    [XmlElement("SUBACCTTO")]                    public required OfxSubAccountEnum SUBACCTTO { get; set; }
    [XmlElement("SUBACCTFROM")]                  public required OfxSubAccountEnum SUBACCTFROM { get; set; }
    [XmlElement("UNITS")]                        public required OfxQuantityType UNITS { get; set; }
}
