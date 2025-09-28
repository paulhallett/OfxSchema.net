// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxPayeeIdType : OfxStringType
{
    // <xsd:simpleType name="PayeeIdType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "PAYEEID" is of type "PayeeIdType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="12" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxPayeeIdType(string value) => new(value);
    public static implicit operator string(OfxPayeeIdType value) => value._backingField;
    
    public OfxPayeeIdType() { }
    private OfxPayeeIdType(string value)
    {
        _backingField = value;
    }
}
