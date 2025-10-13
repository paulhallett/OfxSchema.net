// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxNumberPayments : OfxIntegerType
{
    // <xsd:simpleType name="NumberPayments">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "NUMPMTS" is of type "NumberPayments"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="5" />
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:pattern value="[0-9]+" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxNumberPayments(int value) => new(value);
    public static implicit operator int(OfxNumberPayments value) => value._backingField;
    
    public OfxNumberPayments() { }
    private OfxNumberPayments(int value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField.ToString();
}
