// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxDebtClassEnum
{
    // <xsd:simpleType name="DebtClassEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "DEBTCLASSENUM" is of type "DebtClassEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="TREASURY" />
    //         <xsd:enumeration value="MUNICIPAL" />
    //         <xsd:enumeration value="CORPORATE" />
    //         <xsd:enumeration value="OTHER" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    TREASURY,
    MUNICIPAL,
    CORPORATE,
    OTHER,
}
