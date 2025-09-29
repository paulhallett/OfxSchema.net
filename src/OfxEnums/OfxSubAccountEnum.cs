// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxSubAccountEnum
{
    // <xsd:simpleType name="SubAccountEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SUBACCTENUM" is of type "SubAccountEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="CASH" />
    //         <xsd:enumeration value="MARGIN" />
    //         <xsd:enumeration value="SHORT" />
    //         <xsd:enumeration value="OTHER" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    CASH,
    MARGIN,
    SHORT,
    OTHER,
}
