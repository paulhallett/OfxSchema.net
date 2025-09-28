// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxImageTotalType : OfxIntegerType
{
    // <xsd:simpleType name="ImageTotalType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "DFLTIMAGETTL" is of type "ImageTotalType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="5" />
    //         <xsd:pattern value="[0-9]+" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxImageTotalType(int value) => new(value);
    public static implicit operator int(OfxImageTotalType value) => value._backingField;
    
    public OfxImageTotalType() { }
    private OfxImageTotalType(int value)
    {
        _backingField = value;
    }
}
