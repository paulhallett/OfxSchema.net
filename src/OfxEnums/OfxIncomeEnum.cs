// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxIncomeEnum
{
    // <xsd:simpleType name="IncomeEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INCOMEENUM" is of type "IncomeEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="CGLONG" />
    //         <xsd:enumeration value="CGSHORT" />
    //         <xsd:enumeration value="DIV" />
    //         <xsd:enumeration value="INTEREST" />
    //         <xsd:enumeration value="MISC" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    CGLONG,
    CGSHORT,
    DIV,
    INTEREST,
    MISC,
}
