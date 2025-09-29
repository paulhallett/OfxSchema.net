// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxOptionSellEnum
{
    // <xsd:simpleType name="OptionSellEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "OPTSELLENUM" is of type "OptionSellEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="SELLTOOPEN" />
    //         <xsd:enumeration value="SELLTOCLOSE" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    SELLTOOPEN,
    SELLTOCLOSE,
}
