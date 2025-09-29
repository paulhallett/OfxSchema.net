// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSellStock : OfxAbstractInvestmentSellTransaction
{
    // <xsd:complexType name="SellStock">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SELLSTOCK" is of type "SellStock"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("SELLTYPE")]                     public required OfxSellTypeEnum SELLTYPE { get; set; }
}
