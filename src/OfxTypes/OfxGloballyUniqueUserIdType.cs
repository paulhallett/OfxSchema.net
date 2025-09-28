// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxGloballyUniqueUserIdType : OfxStringType
{
    // <xsd:simpleType name="GloballyUniqueUserIdType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "UUID" is of type "GloballyUniqueUserIdType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="36" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxGloballyUniqueUserIdType(string value) => new(value);
    public static implicit operator string(OfxGloballyUniqueUserIdType value) => value._backingField;
    
    public OfxGloballyUniqueUserIdType() { }
    private OfxGloballyUniqueUserIdType(string value)
    {
        _backingField = value;
    }
}
