// ReSharper disable InconsistentNaming

namespace OfxSchema;

public abstract record OfxAbstractPositionBase
{
    // <xsd:complexType name="AbstractPositionBase">
    // </xsd:complexType>
    
    [XmlElement("INVPOS")]                       public required OfxInvestmentPosition INVPOS { get; set; }
}
