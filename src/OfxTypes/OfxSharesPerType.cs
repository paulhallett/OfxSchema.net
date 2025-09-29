// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSharesPerType : OfxIntegerType
{
    // <xsd:simpleType name="SharesPerType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SHARESPER" is of type "SharesPerType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="5" />
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:pattern value="[0-9]+" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxSharesPerType(int value) => new(value);
    public static implicit operator int(OfxSharesPerType value) => value._backingField;
    
    public OfxSharesPerType() { }
    private OfxSharesPerType(int value)
    {
        _backingField = value;
    }
}
