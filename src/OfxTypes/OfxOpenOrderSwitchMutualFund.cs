// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxOpenOrderSwitchMutualFund : OfxAbstractOpenOrder
{
    // <xsd:complexType name="OpenOrderSwitchMutualFund">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SWITCHMF" is of type "OpenOrderSwitchMutualFund"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("SECID")]                        public required OfxSecurityId SECID { get; set; }
    [XmlElement("UNITTYPE")]                     public required OfxUnitTypeEnum UNITTYPE { get; set; }
    [XmlElement("SWITCHALL")]                    public required OfxBooleanType SWITCHALL { get; set; }
}
