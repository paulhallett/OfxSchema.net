// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxInvestment401kSourceEnum
{
    // <xsd:simpleType name="Investment401kSourceEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INV401KSOURCEENUM" is of type "Investment401kSourceEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="PRETAX" />
    //         <xsd:enumeration value="AFTERTAX" />
    //         <xsd:enumeration value="MATCH" />
    //         <xsd:enumeration value="PROFITSHARING" />
    //         <xsd:enumeration value="ROLLOVER" />
    //         <xsd:enumeration value="OTHERVEST" />
    //         <xsd:enumeration value="OTHERNONVEST" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    PRETAX,
    AFTERTAX,
    MATCH,
    PROFITSHARING,
    ROLLOVER,
    OTHERVEST,
    OTHERNONVEST,
}
