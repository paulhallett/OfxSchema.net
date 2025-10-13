// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxOptionTypeEnum
{
    // <xsd:simpleType name="OptionTypeEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "OPTTYPEENUM" is of type "OptionTypeEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="CALL" />
    //         <xsd:enumeration value="PUT" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    CALL,
    PUT,
}
