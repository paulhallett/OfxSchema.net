// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxTypeDescriptionType : OfxStringType
{
    // <xsd:simpleType name="TypeDescriptionType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "TYPEDESC" is of type "TypeDescriptionType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:maxLength value="32" />
    //         <xsd:minLength value="1" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxTypeDescriptionType(string value) => new(value);
    public static implicit operator string(OfxTypeDescriptionType value) => value._backingField;
    
    public OfxTypeDescriptionType() { }
    private OfxTypeDescriptionType(string value)
    {
        _backingField = value;
    }
}
