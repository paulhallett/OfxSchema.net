// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxBuyEnum
{
    // <xsd:simpleType name="BuyEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "BUYENUM" is of type "BuyEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="BUY" />
    //         <xsd:enumeration value="BUYTOCOVER" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    BUY,
    BUYTOCOVER,
}
