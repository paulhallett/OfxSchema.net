// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxAssetClassEnum
{
    // <xsd:simpleType name="AssetClassEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "ASSETCLASSENUM" is of type "AssetClassEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="DOMESTICBOND" />
    //         <xsd:enumeration value="INTLBOND" />
    //         <xsd:enumeration value="LARGESTOCK" />
    //         <xsd:enumeration value="SMALLSTOCK" />
    //         <xsd:enumeration value="INTLSTOCK" />
    //         <xsd:enumeration value="MONEYMRKT" />
    //         <xsd:enumeration value="OTHER" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    DOMESTICBOND,
    INTLBOND,
    LARGESTOCK,
    SMALLSTOCK,
    INTLSTOCK,
    MONEYMRKT,
    OTHER,
}
