// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxAmountType : OfxDecimalType
{
    // <xsd:simpleType name="AmountType">
    //     <xsd:restriction base="xsd:string">
    //         <xsd:maxLength value="32" />
    //         <xsd:minLength value="1" />
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:pattern value="[\+\-]?[0-9]*(([0-9][,\.]?)|([,\.][0-9]))[0-9]*" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxAmountType(decimal value) => new(value);
    public static implicit operator decimal(OfxAmountType value) => value._backingField;
    
    public OfxAmountType() { }
    private OfxAmountType(decimal value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField.ToString("N2");
}
