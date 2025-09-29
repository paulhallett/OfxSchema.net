// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxBooleanType
{
    // <xsd:simpleType name="BooleanType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "BOOL" is of type "BooleanType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:enumeration value="Y" />
    //         <xsd:enumeration value="N" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    Y,
    N,
}
