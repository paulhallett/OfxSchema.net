// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxErrorType : OfxIntegerType
{
    // <xsd:simpleType name="ErrorType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "ERROR" is of type "ErrorType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="6" />
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:pattern value="[0-9]+" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxErrorType(int value) => new(value);
    public static implicit operator int(OfxErrorType value) => value._backingField;
    
    public OfxErrorType() { }
    private OfxErrorType(int value)
    {
        _backingField = value;
    }
}
