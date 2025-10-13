// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxCouponFrequencyEnum
{
    // <xsd:simpleType name="CouponFrequencyEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "COUPONFREQENUM" is of type "CouponFrequencyEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="MONTHLY" />
    //         <xsd:enumeration value="QUARTERLY" />
    //         <xsd:enumeration value="SEMIANNUAL" />
    //         <xsd:enumeration value="ANNUAL" />
    //         <xsd:enumeration value="OTHER" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    MONTHLY,
    QUARTERLY,
    SEMIANNUAL,
    ANNUAL,
    OTHER,
}
