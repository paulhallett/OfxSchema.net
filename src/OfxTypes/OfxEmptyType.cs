// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxEmptyType : OfxStringType
{
    // <xsd:simpleType name="EmptyType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "EMPTY" is of type "EmptyType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxEmptyType(string value) => new(value);
    public static implicit operator string(OfxEmptyType value) => value._backingField;
    
    public OfxEmptyType() { }
    private OfxEmptyType(string value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField;
}
