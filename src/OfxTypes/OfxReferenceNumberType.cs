// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxReferenceNumberType : OfxStringType
{
    // <xsd:simpleType name="ReferenceNumberType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "REFNUM" is of type "ReferenceNumberType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="32" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxReferenceNumberType(string value) => new(value);
    public static implicit operator string(OfxReferenceNumberType value) => value._backingField;
    
    public OfxReferenceNumberType() { }
    private OfxReferenceNumberType(string value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField;
}
