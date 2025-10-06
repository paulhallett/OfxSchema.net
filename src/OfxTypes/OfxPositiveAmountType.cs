// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxPositiveAmountType : OfxDecimalType
{
    // <xsd:simpleType name="PositiveAmountType">
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="32" />
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:pattern value="\+?[0-9]*(([0-9][,\.]?)|([,\.][0-9]))[0-9]*" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxPositiveAmountType(decimal value) => new(value);
    public static implicit operator decimal(OfxPositiveAmountType value) => value._backingField;
    
    public OfxPositiveAmountType() { }
    private OfxPositiveAmountType(decimal value)
    {
        _backingField = value;
    }
}
