// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInfoType : OfxStringType
{
    // <xsd:simpleType name="InfoType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INFO" is of type "InfoType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="360" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxInfoType(string value) => new(value);
    public static implicit operator string(OfxInfoType value) => value._backingField;
    
    public OfxInfoType() { }
    private OfxInfoType(string value)
    {
        _backingField = value;
    }
}
