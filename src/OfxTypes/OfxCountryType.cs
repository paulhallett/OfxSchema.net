// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxCountryType : OfxStringType
{
    // <xsd:simpleType name="CountryType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               Should be the three-letter country code from ISO/DIS-3166        The OFX element "COUNTRY" is of type "CountryType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="3" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxCountryType(string value) => new(value);
    public static implicit operator string(OfxCountryType value) => value._backingField;
    
    public OfxCountryType() { }
    private OfxCountryType(string value)
    {
        _backingField = value;
    }
}
