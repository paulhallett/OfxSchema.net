// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxExtendedNameType : OfxStringType
{
    // <xsd:simpleType name="ExtendedNameType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "EXTDNAME" is of type "ExtendedNameType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="100" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxExtendedNameType(string value) => new(value);
    public static implicit operator string(OfxExtendedNameType value) => value._backingField;
    
    public OfxExtendedNameType() { }
    private OfxExtendedNameType(string value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField;
}
