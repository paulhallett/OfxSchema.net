// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxOpenOrderBuyMutualFund : OfxAbstractOpenOrder
{
    // <xsd:complexType name="OpenOrderBuyMutualFund">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "OOBUYMF" is of type "OpenOrderBuyMutualFund"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("BUYTYPE")]                      public required OfxBuyEnum BUYTYPE { get; set; }
    [XmlElement("UNITTYPE")]                     public required OfxUnitTypeEnum UNITTYPE { get; set; }
}
