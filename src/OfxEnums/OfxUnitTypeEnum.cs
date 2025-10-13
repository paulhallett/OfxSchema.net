// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxUnitTypeEnum
{
    // <xsd:simpleType name="UnitTypeEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "UNITTYPEENUM" is of type "UnitTypeEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="SHARES" />
    //         <xsd:enumeration value="CURRENCY" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    SHARES,
    CURRENCY,
}
