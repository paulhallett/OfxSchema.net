// ReSharper disable InconsistentNaming

namespace OfxSchema;

public abstract record OfxAbstractOpenOrder
{
    // <xsd:complexType name="AbstractOpenOrder">
    // </xsd:complexType>
    
    [XmlElement("OO")]                           public required OfxGeneralOpenOrder OO { get; set; }
}
