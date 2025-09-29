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
    // </xsd:complexType>
    
    [XmlElement("STOCKTYPE")]                    public OfxStockEnum? STOCKTYPE { get; set; }
    [XmlElement("YIELD")]                        public OfxRateType? YIELD { get; set; }
    [XmlElement("DTYIELDASOF")]                  public OfxDateTimeType? DTYIELDASOF { get; set; }
    [XmlElement("ASSETCLASS")]                   public OfxAssetClassEnum? ASSETCLASS { get; set; }
    [XmlElement("FIASSETCLASS")]                 public OfxGenericNameType? FIASSETCLASS { get; set; }
    
    public virtual bool ShouldSerializeSTOCKTYPE() => STOCKTYPE.HasValue;
    public virtual bool ShouldSerializeASSETCLASS() => ASSETCLASS.HasValue;
}
