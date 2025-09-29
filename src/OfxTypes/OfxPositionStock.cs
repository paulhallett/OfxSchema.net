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
    // </xsd:complexType>
    
    [XmlElement("UNITSSTREET")]                  public OfxPositiveQuantityType? UNITSSTREET { get; set; }
    [XmlElement("UNITSUSER")]                    public OfxPositiveQuantityType? UNITSUSER { get; set; }
    [XmlElement("REINVDIV")]                     public OfxBooleanType? REINVDIV { get; set; }
}
