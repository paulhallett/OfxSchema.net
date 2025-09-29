// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxDurationEnum
{
    // <xsd:simpleType name="DurationEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "DURATIONENUM" is of type "DurationEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="DAY" />
    //         <xsd:enumeration value="GOODTILCANCEL" />
    //         <xsd:enumeration value="IMMEDIATE" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    DAY,
    GOODTILCANCEL,
    IMMEDIATE,
}
