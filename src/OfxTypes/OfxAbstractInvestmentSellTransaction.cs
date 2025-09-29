// ReSharper disable InconsistentNaming

namespace OfxSchema;

public abstract record OfxAbstractInvestmentSellTransaction : OfxAbstractInvestmentTransactionBase
{
    // <xsd:complexType name="AbstractInvestmentSellTransaction">
    // </xsd:complexType>
    
    [XmlElement("INVSELL")]                      public required OfxInvestmentSell INVSELL { get; set; }
}
