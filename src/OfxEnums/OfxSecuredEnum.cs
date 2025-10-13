// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxSecuredEnum
{
    // <xsd:simpleType name="SecuredEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SECUREDENUM" is of type "SecuredEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="NAKED" />
    //         <xsd:enumeration value="COVERED" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    NAKED,
    COVERED,
}
