// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxTickerType : OfxStringType
{
    // <xsd:simpleType name="TickerType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "TICKER" is of type "TickerType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:maxLength value="32" />
    //         <xsd:minLength value="1" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxTickerType(string value) => new(value);
    public static implicit operator string(OfxTickerType value) => value._backingField;
    
    public OfxTickerType() { }
    private OfxTickerType(string value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField;
}
