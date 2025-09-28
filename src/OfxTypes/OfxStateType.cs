// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxStateType : OfxStringType
{
    // <xsd:simpleType name="StateType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "STATE" is of type "StateType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="5" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxStateType(string value) => new(value);
    public static implicit operator string(OfxStateType value) => value._backingField;
    
    public OfxStateType() { }
    private OfxStateType(string value)
    {
        _backingField = value;
    }
}
