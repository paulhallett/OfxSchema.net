// ReSharper disable InconsistentNaming

namespace OfxSchema;

public abstract record OfxAbstractInvestmentSellTransaction : OfxAbstractInvestmentTransactionBase
{
    // <xsd:complexType name="AbstractInvestmentSellTransaction">
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractInvestmentTransactionBase" />
    //             <xsd:sequence>
    //                 <xsd:element name="INVSELL" type="ofx:InvestmentSell" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("INVSELL")]                      public required OfxInvestmentSell INVSELL { get; set; }
}
