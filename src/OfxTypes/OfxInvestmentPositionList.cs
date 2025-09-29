// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentPositionList
{
    // <xsd:complexType name="InvestmentPositionList">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVPOSLIST" is of type "InvestmentPositionList"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("POSMF")]                        public required OfxPositionMutualFund POSMF { get; set; }
    [XmlElement("POSSTOCK")]                     public required OfxPositionStock POSSTOCK { get; set; }
    [XmlElement("POSDEBT")]                      public required OfxPositionDebt POSDEBT { get; set; }
    [XmlElement("POSOPT")]                       public required OfxPositionOption POSOPT { get; set; }
    [XmlElement("POSOTHER")]                     public required OfxPositionOther POSOTHER { get; set; }
}
