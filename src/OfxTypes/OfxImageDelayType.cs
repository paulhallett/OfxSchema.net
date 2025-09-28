// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxImageDelayType : OfxIntegerType
{
    // <xsd:simpleType name="ImageDelayType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "IMAGEDELAYTYPE" is of type "ImageDelayType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="5" />
    //         <xsd:pattern value="[0-9]+" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxImageDelayType(int value) => new(value);
    public static implicit operator int(OfxImageDelayType value) => value._backingField;
    
    public OfxImageDelayType() { }
    private OfxImageDelayType(int value)
    {
        _backingField = value;
    }
}
