// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxMessageBodyType : OfxStringType
{
    // <xsd:simpleType name="MessageBodyType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "MSGBODY" is of type "MessageBodyType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="10000" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxMessageBodyType(string value) => new(value);
    public static implicit operator string(OfxMessageBodyType value) => value._backingField;
    
    public OfxMessageBodyType() { }
    private OfxMessageBodyType(string value)
    {
        _backingField = value;
    }
}
