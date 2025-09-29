// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxSellReasonEnum
{
    // <xsd:simpleType name="SellReasonEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SELLREASONENUM" is of type "SellReasonEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="CALL" />
    //         <xsd:enumeration value="MATURITY" />
    //         <xsd:enumeration value="SELL" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    CALL,
    MATURITY,
    SELL,
}
