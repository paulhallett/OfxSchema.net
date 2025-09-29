// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxCusipType : OfxStringType
{
    // <xsd:simpleType name="CusipType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "CUSIP" is of type "CusipType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="32" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxCusipType(string value) => new(value);
    public static implicit operator string(OfxCusipType value) => value._backingField;
    
    public OfxCusipType() { }
    private OfxCusipType(string value)
    {
        _backingField = value;
    }
}
