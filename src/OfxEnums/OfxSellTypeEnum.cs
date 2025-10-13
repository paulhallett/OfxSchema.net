// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxSellTypeEnum
{
    // <xsd:simpleType name="SellTypeEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SELLTYPEENUM" is of type "SellTypeEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="SELL" />
    //         <xsd:enumeration value="SELLSHORT" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    SELL,
    SELLSHORT,
}
