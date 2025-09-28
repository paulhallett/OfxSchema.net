// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxImageTypeEnum
{
    // <xsd:simpleType name="ImageTypeEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "IMAGETYPE" is of type "ImageTypeEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="STATEMENT" />
    //         <xsd:enumeration value="TRANSACTION" />
    //         <xsd:enumeration value="TAX" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    STATEMENT,
    TRANSACTION,
    TAX,
}
