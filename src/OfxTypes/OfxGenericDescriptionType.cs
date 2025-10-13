// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxGenericDescriptionType : OfxStringType
{
    // <xsd:simpleType name="GenericDescriptionType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "GENDESC" is of type "GenericDescriptionType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="32" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxGenericDescriptionType(string value) => new(value);
    public static implicit operator string(OfxGenericDescriptionType value) => value._backingField;
    
    public OfxGenericDescriptionType() { }
    private OfxGenericDescriptionType(string value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField;
}
