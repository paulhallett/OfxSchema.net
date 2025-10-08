// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSessionCookieType : OfxStringType
{
    // <xsd:simpleType name="SessionCookieType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SESSCOOKIE" is of type "SessionCookieType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="1000" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxSessionCookieType(string value) => new(value);
    public static implicit operator string(OfxSessionCookieType value) => value._backingField;
    
    public OfxSessionCookieType() { }
    private OfxSessionCookieType(string value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField;
}
