// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxStandardIndustryCodeType : OfxIntegerType
{
    // <xsd:simpleType name="StandardIndustryCodeType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SIC" is of type "StandardIndustryCodeType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="6" />
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:pattern value="[0-9]+" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxStandardIndustryCodeType(int value) => new(value);
    public static implicit operator int(OfxStandardIndustryCodeType value) => value._backingField;
    
    public OfxStandardIndustryCodeType() { }
    private OfxStandardIndustryCodeType(int value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField.ToString();
}
