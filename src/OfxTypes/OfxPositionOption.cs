// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxPositionOption : OfxAbstractPositionBase
{
    // <xsd:complexType name="PositionOption">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "POSOPT" is of type "PositionOption"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("SECURED")]                      public OfxSecuredEnum? SECURED { get; set; }
}
