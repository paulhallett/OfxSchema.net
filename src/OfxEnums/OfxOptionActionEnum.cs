// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxOptionActionEnum
{
    // <xsd:simpleType name="OptionActionEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "OPTACTIONENUM" is of type "OptionActionEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="EXERCISE" />
    //         <xsd:enumeration value="ASSIGN" />
    //         <xsd:enumeration value="EXPIRE" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    EXERCISE,
    ASSIGN,
    EXPIRE,
}
