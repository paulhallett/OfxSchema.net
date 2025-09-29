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
    // </xsd:complexType>
    
    [XmlElement("ACCRDINT")]                     public OfxAmountType? ACCRDINT { get; set; }
}
