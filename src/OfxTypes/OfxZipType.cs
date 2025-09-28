// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxZipType : OfxStringType
{
    // <xsd:simpleType name="ZipType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "ZIP" is of type "ZipType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="11" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxZipType(string value) => new(value);
    public static implicit operator string(OfxZipType value) => value._backingField;
    
    public OfxZipType() { }
    private OfxZipType(string value)
    {
        _backingField = value;
    }
}
