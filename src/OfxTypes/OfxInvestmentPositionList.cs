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
    
    
    [XmlElement("POSMF", typeof(OfxPositionMutualFund))]
    [XmlElement("POSSTOCK", typeof(OfxPositionStock))]
    [XmlElement("POSDEBT", typeof(OfxPositionDebt))]
    [XmlElement("POSOPT", typeof(OfxPositionOption))]
    [XmlElement("POSOTHER", typeof(OfxPositionOther))]
    public required List<OfxAbstractPositionBase> ITEMS { get; set; }
    
}
