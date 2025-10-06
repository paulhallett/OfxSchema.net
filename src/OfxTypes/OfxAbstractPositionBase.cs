// ReSharper disable InconsistentNaming

namespace OfxSchema;

public abstract record OfxAbstractPositionBase
{
    // <xsd:complexType name="AbstractPositionBase">
    //     <xsd:sequence>
    //         <xsd:element name="INVPOS" type="ofx:InvestmentPosition" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("INVPOS")]                       public required OfxInvestmentPosition INVPOS { get; set; }
}
