// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxQuantityType : OfxDecimalType
{
    // <xsd:simpleType name="QuantityType">
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="32" />
    //         <xsd:pattern value="[\+\-]?[0-9]*(([0-9][,\.]?)|([,\.][0-9]))[0-9]*" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxQuantityType(decimal value) => new(value);
    public static implicit operator decimal(OfxQuantityType value) => value._backingField;
    
    public OfxQuantityType() { }
    private OfxQuantityType(decimal value)
    {
        _backingField = value;
    }
}
