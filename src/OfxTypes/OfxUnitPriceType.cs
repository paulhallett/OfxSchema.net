// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxUnitPriceType : OfxStringType
{
    // <xsd:simpleType name="UnitPriceType">
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="32" />
    //         <xsd:pattern value="\+?[0-9]*(([0-9][,\.]?)|([,\.][0-9]))[0-9]*" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxUnitPriceType(string value) => new(value);
    public static implicit operator string(OfxUnitPriceType value) => value._backingField;
    
    public OfxUnitPriceType() { }
    private OfxUnitPriceType(string value)
    {
        _backingField = value;
    }
}
