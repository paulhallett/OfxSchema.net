// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxRating : OfxStringType
{
    // <xsd:simpleType name="Rating">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "RATING" is of type "Rating"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:maxLength value="10" />
    //         <xsd:minLength value="1" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxRating(string value) => new(value);
    public static implicit operator string(OfxRating value) => value._backingField;
    
    public OfxRating() { }
    private OfxRating(string value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField;
}
