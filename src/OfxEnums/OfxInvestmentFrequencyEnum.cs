// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxInvestmentFrequencyEnum
{
    // <xsd:simpleType name="InvestmentFrequencyEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "FREQENUM" is of type "FrequencyEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="WEEKLY" />
    //         <xsd:enumeration value="BIWEEKLY" />
    //         <xsd:enumeration value="TWICEMONTHLY" />
    //         <xsd:enumeration value="MONTHLY" />
    //         <xsd:enumeration value="FOURWEEKS" />
    //         <xsd:enumeration value="BIMONTHLY" />
    //         <xsd:enumeration value="QUARTERLY" />
    //         <xsd:enumeration value="SEMIANNUALLY" />
    //         <xsd:enumeration value="ANNUALLY" />
    //         <xsd:enumeration value="OTHER" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    WEEKLY,
    BIWEEKLY,
    TWICEMONTHLY,
    MONTHLY,
    FOURWEEKS,
    BIMONTHLY,
    QUARTERLY,
    SEMIANNUALLY,
    ANNUALLY,
    OTHER,
}
