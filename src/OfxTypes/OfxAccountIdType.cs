// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxAccountIdType : OfxStringType
{
    // <xsd:simpleType name="AccountIdType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "ACCTID" is of type "AccountIdType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:maxLength value="22" />
    //         <xsd:minLength value="1" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxAccountIdType(string value) => new(value);
    public static implicit operator string(OfxAccountIdType value) => value._backingField;
    
    public OfxAccountIdType() { }
    private OfxAccountIdType(string value)
    {
        _backingField = value;
    }
}
