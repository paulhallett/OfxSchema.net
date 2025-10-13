// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxBuyDebt : OfxAbstractInvestmentBuyTransaction
{
    // <xsd:complexType name="BuyDebt">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "BUYDEBT" is of type "BuyDebt"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractInvestmentBuyTransaction" />
    //             <xsd:sequence>
    //                 <xsd:element name="ACCRDINT" type="ofx:AmountType" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("ACCRDINT")]                     public OfxAmountType? ACCRDINT { get; set; }
}
