// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxOtherInfo : OfxAbstractSecurityInfo
{
    // <xsd:complexType name="OtherInfo">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "OTHERINFO" is of type "OtherInfo"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("TYPEDESC")]                     public OfxTypeDescriptionType? TYPEDESC { get; set; }
    [XmlElement("ASSETCLASS")]                   public OfxAssetClassEnum? ASSETCLASS { get; set; }
    [XmlElement("FIASSETCLASS")]                 public OfxGenericNameType? FIASSETCLASS { get; set; }
}
