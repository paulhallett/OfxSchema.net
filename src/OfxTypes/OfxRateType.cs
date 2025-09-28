// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxRateType : OfxDecimalType
{
    // <xsd:simpleType name="RateType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "RATE" is of type "RateType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="32" />
    //         <xsd:pattern value="[\+\-]?[0-9]*(([0-9][,\.]?)|([,\.][0-9]))[0-9]*" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxRateType(decimal value) => new(value);
    public static implicit operator decimal(OfxRateType value) => value._backingField;
    
    public OfxRateType() { }
    private OfxRateType(decimal value)
    {
        _backingField = value;
    }
}
