// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSecurityNameType : OfxStringType
{
    // <xsd:simpleType name="SecurityNameType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SECNAME" is of type "SecurityNameType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="120" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxSecurityNameType(string value) => new(value);
    public static implicit operator string(OfxSecurityNameType value) => value._backingField;
    
    public OfxSecurityNameType() { }
    private OfxSecurityNameType(string value)
    {
        _backingField = value;
    }
}
