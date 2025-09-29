// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxWithdrawals
{
    // <xsd:complexType name="Withdrawals">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "WITHDRAWALS" is of type "Withdrawals"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("PRETAX")]                       public OfxAmountType? PRETAX { get; set; }
    [XmlElement("AFTERTAX")]                     public OfxAmountType? AFTERTAX { get; set; }
    [XmlElement("MATCH")]                        public OfxAmountType? MATCH { get; set; }
    [XmlElement("PROFITSHARING")]                public OfxAmountType? PROFITSHARING { get; set; }
    [XmlElement("ROLLOVER")]                     public OfxAmountType? ROLLOVER { get; set; }
    [XmlElement("OTHERVEST")]                    public OfxAmountType? OTHERVEST { get; set; }
    [XmlElement("OTHERNONVEST")]                 public OfxAmountType? OTHERNONVEST { get; set; }
    [XmlElement("TOTAL")]                        public required OfxAmountType TOTAL { get; set; }
}
