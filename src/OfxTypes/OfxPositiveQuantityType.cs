// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxPositiveQuantityType : OfxDecimalType
{
    // <xsd:simpleType name="PositiveQuantityType">
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="32" />
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:pattern value="\+?[0-9]*(([0-9][,\.]?)|([,\.][0-9]))[0-9]*" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxPositiveQuantityType(decimal value) => new(value);
    public static implicit operator decimal(OfxPositiveQuantityType value) => value._backingField;
    
    public OfxPositiveQuantityType() { }
    private OfxPositiveQuantityType(decimal value)
    {
        _backingField = value;
    }
}
