// ReSharper disable InconsistentNaming

namespace OfxSchema;

public abstract record OfxAbstractInvestmentTransaction : OfxAbstractInvestmentTransactionBase
{
    // <xsd:complexType name="AbstractInvestmentTransaction">
    // </xsd:complexType>
    
    [XmlElement("INVTRAN")]                      public required OfxInvestmentTransaction INVTRAN { get; set; }
}
