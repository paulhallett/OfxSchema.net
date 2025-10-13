// ReSharper disable InconsistentNaming

namespace OfxSchema;

public abstract record OfxAbstractInvestmentTransaction : OfxAbstractInvestmentTransactionBase
{
    // <xsd:complexType name="AbstractInvestmentTransaction">
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractInvestmentTransactionBase" />
    //             <xsd:sequence>
    //                 <xsd:element name="INVTRAN" type="ofx:InvestmentTransaction" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("INVTRAN")]                      public required OfxInvestmentTransaction INVTRAN { get; set; }
}
