// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxStockEnum
{
    // <xsd:simpleType name="StockEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "STOCKENUM" is of type "StockEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="COMMON" />
    //         <xsd:enumeration value="PREFERRED" />
    //         <xsd:enumeration value="CONVERTIBLE" />
    //         <xsd:enumeration value="OTHER" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    COMMON,
    PREFERRED,
    CONVERTIBLE,
    OTHER,
}
