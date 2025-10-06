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
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractSecurityInfo" />
    //             <xsd:sequence>
    //                 <xsd:element name="TYPEDESC" type="ofx:TypeDescriptionType" minOccurs="0" />
    //                 <xsd:element name="ASSETCLASS" type="ofx:AssetClassEnum" minOccurs="0" />
    //                 <xsd:element name="FIASSETCLASS" type="ofx:GenericNameType" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("TYPEDESC")]                     public OfxTypeDescriptionType? TYPEDESC { get; set; }
    [XmlElement("ASSETCLASS")]                   public OfxAssetClassEnum? ASSETCLASS { get; set; }
    [XmlElement("FIASSETCLASS")]                 public OfxGenericNameType? FIASSETCLASS { get; set; }
    
    public virtual bool ShouldSerializeASSETCLASS() => ASSETCLASS.HasValue;
}
