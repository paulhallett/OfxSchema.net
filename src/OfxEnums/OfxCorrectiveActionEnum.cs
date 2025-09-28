// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxCorrectiveActionEnum
{
    // <xsd:simpleType name="CorrectiveActionEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "CORRECTIVEACTENUM" is of type "CorrectiveActionEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="REPLACE" />
    //         <xsd:enumeration value="DELETE" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    REPLACE,
    DELETE,
}
