// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxPositionStock : OfxAbstractPositionBase
{
    // <xsd:complexType name="PositionStock">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "POSSTOCK" is of type "PositionStock"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractPositionBase" />
    //             <xsd:sequence>
    //                 <xsd:element name="UNITSSTREET" type="ofx:PositiveQuantityType" minOccurs="0" />
    //                 <xsd:element name="UNITSUSER" type="ofx:PositiveQuantityType" minOccurs="0" />
    //                 <xsd:element name="REINVDIV" type="ofx:BooleanType" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("UNITSSTREET")]                  public OfxPositiveQuantityType? UNITSSTREET { get; set; }
    [XmlElement("UNITSUSER")]                    public OfxPositiveQuantityType? UNITSUSER { get; set; }
    [XmlElement("REINVDIV")]                     public OfxBooleanType? REINVDIV { get; set; }
    
    public virtual bool ShouldSerializeREINVDIV() => REINVDIV.HasValue;
}
