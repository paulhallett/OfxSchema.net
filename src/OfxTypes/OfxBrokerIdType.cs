// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxBrokerIdType : OfxStringType
{
    // <xsd:simpleType name="BrokerIdType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "BROKERID" is of type "BrokerIdType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:maxLength value="22" />
    //         <xsd:minLength value="1" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxBrokerIdType(string value) => new(value);
    public static implicit operator string(OfxBrokerIdType value) => value._backingField;
    
    public OfxBrokerIdType() { }
    private OfxBrokerIdType(string value)
    {
        _backingField = value;
    }
}
