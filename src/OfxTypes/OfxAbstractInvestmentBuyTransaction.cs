// ReSharper disable InconsistentNaming

namespace OfxSchema;

public abstract record OfxAbstractInvestmentBuyTransaction : OfxAbstractInvestmentTransactionBase
{
    // <xsd:complexType name="AbstractInvestmentBuyTransaction">
    // </xsd:complexType>
    
    [XmlElement("INVBUY")]                       public required OfxInvestmentBuy INVBUY { get; set; }
}
