// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxStockInfo : OfxAbstractSecurityInfo
{
    // <xsd:complexType name="StockInfo">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "STOCKINFO" is of type "StockInfo"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractSecurityInfo" />
    //             <xsd:sequence>
    //                 <xsd:element name="STOCKTYPE" type="ofx:StockEnum" minOccurs="0" />
    //                 <xsd:element name="YIELD" type="ofx:RateType" minOccurs="0" />
    //                 <xsd:element name="DTYIELDASOF" type="ofx:DateTimeType" minOccurs="0" />
    //                 <xsd:element name="ASSETCLASS" type="ofx:AssetClassEnum" minOccurs="0" />
    //                 <xsd:element name="FIASSETCLASS" type="ofx:GenericNameType" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("STOCKTYPE")]                    public OfxStockEnum? STOCKTYPE { get; set; }
    [XmlElement("YIELD")]                        public OfxRateType? YIELD { get; set; }
    [XmlElement("DTYIELDASOF")]                  public OfxDateTimeType? DTYIELDASOF { get; set; }
    [XmlElement("ASSETCLASS")]                   public OfxAssetClassEnum? ASSETCLASS { get; set; }
    [XmlElement("FIASSETCLASS")]                 public OfxGenericNameType? FIASSETCLASS { get; set; }
    
    public virtual bool ShouldSerializeSTOCKTYPE() => STOCKTYPE.HasValue;
    public virtual bool ShouldSerializeASSETCLASS() => ASSETCLASS.HasValue;
}
