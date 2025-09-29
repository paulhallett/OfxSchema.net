// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxPositiveQuantityType : OfxStringType
{
    // <xsd:simpleType name="PositiveQuantityType">
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="32" />
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:pattern value="\+?[0-9]*(([0-9][,\.]?)|([,\.][0-9]))[0-9]*" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxPositiveQuantityType(string value) => new(value);
    public static implicit operator string(OfxPositiveQuantityType value) => value._backingField;
    
    public OfxPositiveQuantityType() { }
    private OfxPositiveQuantityType(string value)
    {
        _backingField = value;
    }
}
