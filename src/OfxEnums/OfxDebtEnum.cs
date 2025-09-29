// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxDebtEnum
{
    // <xsd:simpleType name="DebtEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "DEBTENUM" is of type "DebtEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="COUPON" />
    //         <xsd:enumeration value="ZERO" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    COUPON,
    ZERO,
}
