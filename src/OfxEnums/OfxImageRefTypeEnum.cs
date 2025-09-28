// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxImageRefTypeEnum
{
    // <xsd:simpleType name="ImageRefTypeEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "IMAGEREFTYPE" is of type "ImageTypeEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="OPAQUE" />
    //         <xsd:enumeration value="URL" />
    //         <xsd:enumeration value="FORMURL" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    OPAQUE,
    URL,
    FORMURL,
}
