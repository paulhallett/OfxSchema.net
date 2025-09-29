// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSellDebt : OfxAbstractInvestmentSellTransaction
{
    // <xsd:complexType name="SellDebt">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SELLDEBT" is of type "SellDebt"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("SELLREASON")]                   public required OfxSellReasonEnum SELLREASON { get; set; }
    [XmlElement("ACCRDINT")]                     public OfxAmountType? ACCRDINT { get; set; }
}
