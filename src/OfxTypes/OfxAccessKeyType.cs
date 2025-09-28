// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxAccessKeyType : OfxStringType
{
    // <xsd:simpleType name="AccessKeyType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "ACCESSKEY" is of type "AccessKeyType".
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="1000" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxAccessKeyType(string value) => new(value);
    public static implicit operator string(OfxAccessKeyType value) => value._backingField;
    
    public OfxAccessKeyType() { }
    private OfxAccessKeyType(string value)
    {
        _backingField = value;
    }
}
