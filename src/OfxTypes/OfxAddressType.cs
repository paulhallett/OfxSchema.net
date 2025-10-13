// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxAddressType : OfxStringType
{
    // <xsd:simpleType name="AddressType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "ADDRESS" is of type "AddressType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:maxLength value="32" />
    //         <xsd:minLength value="1" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxAddressType(string value) => new(value);
    public static implicit operator string(OfxAddressType value) => value._backingField;
    
    public OfxAddressType() { }
    private OfxAddressType(string value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField;
}
