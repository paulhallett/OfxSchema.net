// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxServerIdType : OfxStringType
{
    // <xsd:simpleType name="ServerIdType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SRVRTID" is of type "ServerIdType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="10" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxServerIdType(string value) => new(value);
    public static implicit operator string(OfxServerIdType value) => value._backingField;
    
    public OfxServerIdType() { }
    private OfxServerIdType(string value)
    {
        _backingField = value;
    }
}
