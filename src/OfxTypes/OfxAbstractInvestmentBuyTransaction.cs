// ReSharper disable InconsistentNaming

namespace OfxSchema;

public abstract record OfxAbstractInvestmentBuyTransaction : OfxAbstractInvestmentTransactionBase
{
    // <xsd:complexType name="AbstractInvestmentBuyTransaction">
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractInvestmentTransactionBase" />
    //             <xsd:sequence>
    //                 <xsd:element name="INVBUY" type="ofx:InvestmentBuy" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("INVBUY")]                       public required OfxInvestmentBuy INVBUY { get; set; }
}
