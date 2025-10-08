// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxImageRefType : OfxStringType
{
    // <xsd:simpleType name="ImageRefType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "IMAGEREF" is of type "ImageRefype"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:maxLength value="1024" />
    //         <xsd:minLength value="1" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxImageRefType(string value) => new(value);
    public static implicit operator string(OfxImageRefType value) => value._backingField;
    
    public OfxImageRefType() { }
    private OfxImageRefType(string value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField;
}
