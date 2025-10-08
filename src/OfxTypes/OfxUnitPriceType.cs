// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxUnitPriceType : OfxDecimalType
{
    // <xsd:simpleType name="UnitPriceType">
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="32" />
    //         <xsd:pattern value="\+?[0-9]*(([0-9][,\.]?)|([,\.][0-9]))[0-9]*" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxUnitPriceType(decimal value) => new(value);
    public static implicit operator decimal(OfxUnitPriceType value) => value._backingField;
    
    public OfxUnitPriceType() { }
    private OfxUnitPriceType(decimal value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField.ToString("N2");
}
