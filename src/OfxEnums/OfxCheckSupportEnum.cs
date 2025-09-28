// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxCheckSupportEnum
{
    // <xsd:simpleType name="CheckSupportEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "CHECKSUP" is of type "CheckSupportEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="FRONTONLY" />
    //         <xsd:enumeration value="BACKONLY" />
    //         <xsd:enumeration value="FRONTANDBACK" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    FRONTONLY,
    BACKONLY,
    FRONTANDBACK,
}
