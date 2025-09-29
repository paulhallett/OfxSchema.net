// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxRestrictionEnum
{
    // <xsd:simpleType name="RestrictionEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "RESTRICTIONENUM" is of type "RestrictionEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="ALLORNONE" />
    //         <xsd:enumeration value="MINUNITS" />
    //         <xsd:enumeration value="NONE" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    ALLORNONE,
    MINUNITS,
    NONE,
}
