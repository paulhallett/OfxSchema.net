// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSecurityUserIdType : OfxStringType
{
    // <xsd:simpleType name="SecurityUserIdType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SECUID" is of type "SecurityUserIdType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="10" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxSecurityUserIdType(string value) => new(value);
    public static implicit operator string(OfxSecurityUserIdType value) => value._backingField;
    
    public OfxSecurityUserIdType() { }
    private OfxSecurityUserIdType(string value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField;
}
