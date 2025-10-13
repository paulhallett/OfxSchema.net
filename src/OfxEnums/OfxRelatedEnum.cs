// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxRelatedEnum
{
    // <xsd:simpleType name="RelatedEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "RELATEDENUM" is of type "RelatedEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="SPREAD" />
    //         <xsd:enumeration value="STRADDLE" />
    //         <xsd:enumeration value="NONE" />
    //         <xsd:enumeration value="OTHER" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    SPREAD,
    STRADDLE,
    NONE,
    OTHER,
}
