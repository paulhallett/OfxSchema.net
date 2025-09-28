// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxMessageType : OfxStringType
{
    // <xsd:simpleType name="MessageType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "MSG" is of type "MessageType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="255" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxMessageType(string value) => new(value);
    public static implicit operator string(OfxMessageType value) => value._backingField;
    
    public OfxMessageType() { }
    private OfxMessageType(string value)
    {
        _backingField = value;
    }
}
