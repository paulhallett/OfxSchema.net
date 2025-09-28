// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxUserKeyType : OfxStringType
{
    // <xsd:simpleType name="UserKeyType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "USERKEY" is of type "UserKeyType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="64" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxUserKeyType(string value) => new(value);
    public static implicit operator string(OfxUserKeyType value) => value._backingField;
    
    public OfxUserKeyType() { }
    private OfxUserKeyType(string value)
    {
        _backingField = value;
    }
}
