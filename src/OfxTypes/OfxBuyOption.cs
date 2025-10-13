// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxBuyOption : OfxAbstractInvestmentBuyTransaction
{
    // <xsd:complexType name="BuyOption">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "BUYOPT" is of type "BuyOption"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractInvestmentBuyTransaction" />
    //             <xsd:sequence>
    //                 <xsd:element name="OPTBUYTYPE" type="ofx:OptionBuyEnum" />
    //                 <xsd:element name="SHPERCTRCT" type="ofx:SharesPerType" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("OPTBUYTYPE")]                   public required OfxOptionBuyEnum OPTBUYTYPE { get; set; }
    [XmlElement("SHPERCTRCT")]                   public required OfxSharesPerType SHPERCTRCT { get; set; }
}
