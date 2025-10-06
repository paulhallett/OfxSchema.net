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
    //     <xsd:sequence>
    //         <xsd:choice minOccurs="0" maxOccurs="unbounded">
    //             <xsd:element name="POSMF" type="ofx:PositionMutualFund" />
    //             <xsd:element name="POSSTOCK" type="ofx:PositionStock" />
    //             <xsd:element name="POSDEBT" type="ofx:PositionDebt" />
    //             <xsd:element name="POSOPT" type="ofx:PositionOption" />
    //             <xsd:element name="POSOTHER" type="ofx:PositionOther" />
    //         </xsd:choice>
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("POSMF")]                        public OfxPositionMutualFund? POSMF { get; set; }
    [XmlElement("POSSTOCK")]                     public OfxPositionStock? POSSTOCK { get; set; }
    [XmlElement("POSDEBT")]                      public OfxPositionDebt? POSDEBT { get; set; }
    [XmlElement("POSOPT")]                       public OfxPositionOption? POSOPT { get; set; }
    [XmlElement("POSOTHER")]                     public OfxPositionOther? POSOTHER { get; set; }
}
