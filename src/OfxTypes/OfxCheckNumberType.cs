// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxCheckNumberType : OfxStringType
{
    // <xsd:simpleType name="CheckNumberType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "CHECKNUM" is of type "CheckNumberType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="12" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxCheckNumberType(string value) => new(value);
    public static implicit operator string(OfxCheckNumberType value) => value._backingField;
    
    public OfxCheckNumberType() { }
    private OfxCheckNumberType(string value)
    {
        _backingField = value;
    }
}
