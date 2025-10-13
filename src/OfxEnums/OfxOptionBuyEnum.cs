// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxOptionBuyEnum
{
    // <xsd:simpleType name="OptionBuyEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "OPTBUYENUM" is of type "OptionBuyEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="BUYTOOPEN" />
    //         <xsd:enumeration value="BUYTOCLOSE" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    BUYTOOPEN,
    BUYTOCLOSE,
}
