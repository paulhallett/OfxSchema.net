// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxGenericContactInfoType : OfxStringType
{
    // <xsd:simpleType name="GenericContactInfoType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "GENCONTACTINFO" is of type "GenericContactInfoType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:maxLength value="255" />
    //         <xsd:minLength value="1" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxGenericContactInfoType(string value) => new(value);
    public static implicit operator string(OfxGenericContactInfoType value) => value._backingField;
    
    public OfxGenericContactInfoType() { }
    private OfxGenericContactInfoType(string value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField;
}
