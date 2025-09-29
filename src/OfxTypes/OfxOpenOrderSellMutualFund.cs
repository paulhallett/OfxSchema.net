// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxOpenOrderSellMutualFund : OfxAbstractOpenOrder
{
    // <xsd:complexType name="OpenOrderSellMutualFund">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "OOSELLMF" is of type "OpenOrderSellMutualFund"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("SELLTYPE")]                     public required OfxSellTypeEnum SELLTYPE { get; set; }
    [XmlElement("UNITTYPE")]                     public required OfxUnitTypeEnum UNITTYPE { get; set; }
    [XmlElement("SELLALL")]                      public required OfxBooleanType SELLALL { get; set; }
}
