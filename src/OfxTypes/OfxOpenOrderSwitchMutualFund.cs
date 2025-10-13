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
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractOpenOrder" />
    //             <xsd:sequence>
    //                 <xsd:element name="SECID" type="ofx:SecurityId" />
    //                 <xsd:element name="UNITTYPE" type="ofx:UnitTypeEnum" />
    //                 <xsd:element name="SWITCHALL" type="ofx:BooleanType" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("SECID")]                        public required OfxSecurityId SECID { get; set; }
    [XmlElement("UNITTYPE")]                     public required OfxUnitTypeEnum UNITTYPE { get; set; }
    [XmlElement("SWITCHALL")]                    public required OfxBooleanType SWITCHALL { get; set; }
}
