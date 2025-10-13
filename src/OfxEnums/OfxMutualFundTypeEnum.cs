// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxMutualFundTypeEnum
{
    // <xsd:simpleType name="MutualFundTypeEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "MFTENUM" is of type "MutualFundTypeEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="OPENEND" />
    //         <xsd:enumeration value="CLOSEEND" />
    //         <xsd:enumeration value="OTHER" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    OPENEND,
    CLOSEEND,
    OTHER,
}
