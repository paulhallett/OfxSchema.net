// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxGenericNameType : OfxStringType
{
    // <xsd:simpleType name="GenericNameType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "GENNAME" is of type "GenericNameType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="32" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxGenericNameType(string value) => new(value);
    public static implicit operator string(OfxGenericNameType value) => value._backingField;
    
    public OfxGenericNameType() { }
    private OfxGenericNameType(string value)
    {
        _backingField = value;
    }
}
