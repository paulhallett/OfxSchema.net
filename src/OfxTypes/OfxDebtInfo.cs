// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxDebtInfo : OfxAbstractSecurityInfo
{
    // <xsd:complexType name="DebtInfo">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "DEBTINFO" is of type "DebtInfo"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("PARVALUE")]                     public required OfxAmountType PARVALUE { get; set; }
    [XmlElement("DEBTTYPE")]                     public required OfxDebtEnum DEBTTYPE { get; set; }
    [XmlElement("DEBTCLASS")]                    public OfxDebtClassEnum? DEBTCLASS { get; set; }
    [XmlElement("COUPONRT")]                     public OfxRateType? COUPONRT { get; set; }
    [XmlElement("DTCOUPON")]                     public OfxDateTimeType? DTCOUPON { get; set; }
    [XmlElement("COUPONFREQ")]                   public OfxCouponFrequencyEnum? COUPONFREQ { get; set; }
    [XmlElement("CALLPRICE")]                    public OfxUnitPriceType? CALLPRICE { get; set; }
    [XmlElement("YIELDTOCALL")]                  public OfxRateType? YIELDTOCALL { get; set; }
    [XmlElement("DTCALL")]                       public OfxDateTimeType? DTCALL { get; set; }
    [XmlElement("CALLTYPE")]                     public OfxCallTypeEnum? CALLTYPE { get; set; }
    [XmlElement("YIELDTOMAT")]                   public OfxRateType? YIELDTOMAT { get; set; }
    [XmlElement("DTMAT")]                        public OfxDateTimeType? DTMAT { get; set; }
    [XmlElement("ASSETCLASS")]                   public OfxAssetClassEnum? ASSETCLASS { get; set; }
    [XmlElement("FIASSETCLASS")]                 public OfxGenericNameType? FIASSETCLASS { get; set; }
}
