// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxPhoneType : OfxStringType
{
    // <xsd:simpleType name="PhoneType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "PHONE" is of type "PhoneType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="32" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxPhoneType(string value) => new(value);
    public static implicit operator string(OfxPhoneType value) => value._backingField;
    
    public OfxPhoneType() { }
    private OfxPhoneType(string value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField;
}
