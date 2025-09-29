// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxPositionTypeEnum
{
    // <xsd:simpleType name="PositionTypeEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "POSTYPEENUM" is of type "PositionTypeEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="LONG" />
    //         <xsd:enumeration value="SHORT" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    LONG,
    SHORT,
}
