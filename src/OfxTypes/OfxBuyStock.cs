// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxBuyStock : OfxAbstractInvestmentBuyTransaction
{
    // <xsd:complexType name="BuyStock">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "BUYSTOCK" is of type "BuyStock"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("BUYTYPE")]                      public required OfxBuyEnum BUYTYPE { get; set; }
}
