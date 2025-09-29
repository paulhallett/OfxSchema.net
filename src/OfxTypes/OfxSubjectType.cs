// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSubjectType : OfxStringType
{
    // <xsd:simpleType name="SubjectType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SUBJECT" is of type "SubjectType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="60" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxSubjectType(string value) => new(value);
    public static implicit operator string(OfxSubjectType value) => value._backingField;
    
    public OfxSubjectType() { }
    private OfxSubjectType(string value)
    {
        _backingField = value;
    }
}
