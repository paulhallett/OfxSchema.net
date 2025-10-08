// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxShortMessageType : OfxStringType
{
    // <xsd:simpleType name="ShortMessageType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SHORTMSG" is of type "ShortMessageType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="80" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxShortMessageType(string value) => new(value);
    public static implicit operator string(OfxShortMessageType value) => value._backingField;
    
    public OfxShortMessageType() { }
    private OfxShortMessageType(string value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField;
}
