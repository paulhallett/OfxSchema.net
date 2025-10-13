// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxSeverityEnum
{
    // <xsd:simpleType name="SeverityEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SEVERITYENUM" is of type "SeverityEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="INFO" />
    //         <xsd:enumeration value="WARN" />
    //         <xsd:enumeration value="ERROR" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    INFO,
    WARN,
    ERROR,
}
