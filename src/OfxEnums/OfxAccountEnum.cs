// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxAccountEnum
{
    // <xsd:simpleType name="AccountEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "ACCTTYPE" is of type "AccountEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="CHECKING" />
    //         <xsd:enumeration value="SAVINGS" />
    //         <xsd:enumeration value="MONEYMRKT" />
    //         <xsd:enumeration value="CREDITLINE" />
    //         <xsd:enumeration value="CD" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    CHECKING,
    SAVINGS,
    MONEYMRKT,
    CREDITLINE,
    CD,
}
