// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxOptionInfo : OfxAbstractSecurityInfo
{
    // <xsd:complexType name="OptionInfo">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "OPTINFO" is of type "OptionInfo"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractSecurityInfo" />
    //             <xsd:sequence>
    //                 <xsd:element name="OPTTYPE" type="ofx:OptionTypeEnum" />
    //                 <xsd:element name="STRIKEPRICE" type="ofx:UnitPriceType" />
    //                 <xsd:element name="DTEXPIRE" type="ofx:DateTimeType" />
    //                 <xsd:element name="SHPERCTRCT" type="ofx:SharesPerType" />
    //                 <xsd:element name="SECID" type="ofx:SecurityId" minOccurs="0" />
    //                 <xsd:element name="ASSETCLASS" type="ofx:AssetClassEnum" minOccurs="0" />
    //                 <xsd:element name="FIASSETCLASS" type="ofx:GenericNameType" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("OPTTYPE")]                      public required OfxOptionTypeEnum OPTTYPE { get; set; }
    [XmlElement("STRIKEPRICE")]                  public required OfxUnitPriceType STRIKEPRICE { get; set; }
    [XmlElement("DTEXPIRE")]                     public required OfxDateTimeType DTEXPIRE { get; set; }
    [XmlElement("SHPERCTRCT")]                   public required OfxSharesPerType SHPERCTRCT { get; set; }
    [XmlElement("SECID")]                        public OfxSecurityId? SECID { get; set; }
    [XmlElement("ASSETCLASS")]                   public OfxAssetClassEnum? ASSETCLASS { get; set; }
    [XmlElement("FIASSETCLASS")]                 public OfxGenericNameType? FIASSETCLASS { get; set; }
    
    public virtual bool ShouldSerializeASSETCLASS() => ASSETCLASS.HasValue;
}
