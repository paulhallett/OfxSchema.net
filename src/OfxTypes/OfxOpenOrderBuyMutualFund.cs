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
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractOpenOrder" />
    //             <xsd:sequence>
    //                 <xsd:element name="BUYTYPE" type="ofx:BuyEnum" />
    //                 <xsd:element name="UNITTYPE" type="ofx:UnitTypeEnum" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("BUYTYPE")]                      public required OfxBuyEnum BUYTYPE { get; set; }
    [XmlElement("UNITTYPE")]                     public required OfxUnitTypeEnum UNITTYPE { get; set; }
}
