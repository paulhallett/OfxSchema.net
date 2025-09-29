// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxCallTypeEnum
{
    // <xsd:simpleType name="CallTypeEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "CALLTYPEENUM" is of type "CallTypeEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="CALL" />
    //         <xsd:enumeration value="PUT" />
    //         <xsd:enumeration value="PREFUND" />
    //         <xsd:enumeration value="MATURITY" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    CALL,
    PUT,
    PREFUND,
    MATURITY,
}
