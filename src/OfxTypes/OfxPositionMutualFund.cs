// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxPositionMutualFund : OfxAbstractPositionBase
{
    // <xsd:complexType name="PositionMutualFund">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "POSMF" is of type "PositionMutualFund"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractPositionBase" />
    //             <xsd:sequence>
    //                 <xsd:element name="UNITSSTREET" type="ofx:PositiveQuantityType" minOccurs="0" />
    //                 <xsd:element name="UNITSUSER" type="ofx:PositiveQuantityType" minOccurs="0" />
    //                 <xsd:element name="REINVDIV" type="ofx:BooleanType" minOccurs="0" />
    //                 <xsd:element name="REINVCG" type="ofx:BooleanType" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("UNITSSTREET")]                  public OfxPositiveQuantityType? UNITSSTREET { get; set; }
    [XmlElement("UNITSUSER")]                    public OfxPositiveQuantityType? UNITSUSER { get; set; }
    [XmlElement("REINVDIV")]                     public OfxBooleanType? REINVDIV { get; set; }
    [XmlElement("REINVCG")]                      public OfxBooleanType? REINVCG { get; set; }
    
    public virtual bool ShouldSerializeREINVDIV() => REINVDIV.HasValue;
    public virtual bool ShouldSerializeREINVCG() => REINVCG.HasValue;
}
