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
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractPositionBase" />
    //             <xsd:sequence>
    //                 <xsd:element name="SECURED" type="ofx:SecuredEnum" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("SECURED")]                      public OfxSecuredEnum? SECURED { get; set; }
    
    public virtual bool ShouldSerializeSECURED() => SECURED.HasValue;
}
