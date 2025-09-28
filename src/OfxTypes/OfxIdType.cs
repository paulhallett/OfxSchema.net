// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxIdType : OfxStringType
{
    // <xsd:simpleType name="IdType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "ID" is of type "IdType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="32" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxIdType(string value) => new(value);
    public static implicit operator string(OfxIdType value) => value._backingField;
    
    public OfxIdType() { }
    private OfxIdType(string value)
    {
        _backingField = value;
    }
}
