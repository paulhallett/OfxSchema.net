// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxErrorType : OfxStringType
{
    // <xsd:simpleType name="ErrorType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "ERROR" is of type "ErrorType"
    //             </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="6" />
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:pattern value="[0-9]+" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxErrorType(string value) => new(value);

    public OfxErrorType() { }
    private OfxErrorType(string value)
    {
        _backingField = value;
    }
}