// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxBalanceEnum
{
    // <xsd:simpleType name="BalanceEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "BALANCEENUM" is of type "BalanceEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="DOLLAR" />
    //         <xsd:enumeration value="PERCENT" />
    //         <xsd:enumeration value="NUMBER" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    DOLLAR,
    PERCENT,
    NUMBER,
}
