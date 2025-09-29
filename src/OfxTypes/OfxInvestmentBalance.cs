// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentBalance
{
    // <xsd:complexType name="InvestmentBalance">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVBAL" is of type "InvestmentBalance"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("AVAILCASH")]                    public required OfxAmountType AVAILCASH { get; set; }
    [XmlElement("MARGINBALANCE")]                public required OfxAmountType MARGINBALANCE { get; set; }
    [XmlElement("SHORTBALANCE")]                 public required OfxAmountType SHORTBALANCE { get; set; }
    [XmlElement("BUYPOWER")]                     public OfxAmountType? BUYPOWER { get; set; }
    [XmlElement("BALLIST")]                      public OfxBalanceList? BALLIST { get; set; }
}
