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
    // </xsd:complexType>
    
    [XmlElement("UNITSSTREET")]                  public OfxPositiveQuantityType? UNITSSTREET { get; set; }
    [XmlElement("UNITSUSER")]                    public OfxPositiveQuantityType? UNITSUSER { get; set; }
    [XmlElement("REINVDIV")]                     public OfxBooleanType? REINVDIV { get; set; }
    [XmlElement("REINVCG")]                      public OfxBooleanType? REINVCG { get; set; }
    
    public virtual bool ShouldSerializeREINVDIV() => REINVDIV.HasValue;
    public virtual bool ShouldSerializeREINVCG() => REINVCG.HasValue;
}
