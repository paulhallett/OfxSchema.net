// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxInOutEnum
{
    // <xsd:simpleType name="InOutEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INOUTENUM" is of type "InOutEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="IN" />
    //         <xsd:enumeration value="OUT" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    IN,
    OUT,
}
