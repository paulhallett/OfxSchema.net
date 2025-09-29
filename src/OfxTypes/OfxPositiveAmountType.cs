// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxPositiveAmountType : OfxStringType
{
    // <xsd:simpleType name="PositiveAmountType">
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="32" />
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:pattern value="\+?[0-9]*(([0-9][,\.]?)|([,\.][0-9]))[0-9]*" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxPositiveAmountType(string value) => new(value);
    public static implicit operator string(OfxPositiveAmountType value) => value._backingField;
    
    public OfxPositiveAmountType() { }
    private OfxPositiveAmountType(string value)
    {
        _backingField = value;
    }
}
