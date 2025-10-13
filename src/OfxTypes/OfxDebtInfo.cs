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
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractSecurityInfo" />
    //             <xsd:sequence>
    //                 <xsd:element name="PARVALUE" type="ofx:AmountType" />
    //                 <xsd:element name="DEBTTYPE" type="ofx:DebtEnum" />
    //                 <xsd:element name="DEBTCLASS" type="ofx:DebtClassEnum" minOccurs="0" />
    //                 <xsd:element name="COUPONRT" type="ofx:RateType" minOccurs="0" />
    //                 <xsd:element name="DTCOUPON" type="ofx:DateTimeType" minOccurs="0" />
    //                 <xsd:element name="COUPONFREQ" type="ofx:CouponFrequencyEnum" minOccurs="0" />
    //                 <xsd:element name="CALLPRICE" type="ofx:UnitPriceType" minOccurs="0" />
    //                 <xsd:element name="YIELDTOCALL" type="ofx:RateType" minOccurs="0" />
    //                 <xsd:element name="DTCALL" type="ofx:DateTimeType" minOccurs="0" />
    //                 <xsd:element name="CALLTYPE" type="ofx:CallTypeEnum" minOccurs="0" />
    //                 <xsd:element name="YIELDTOMAT" type="ofx:RateType" minOccurs="0" />
    //                 <xsd:element name="DTMAT" type="ofx:DateTimeType" minOccurs="0" />
    //                 <xsd:element name="ASSETCLASS" type="ofx:AssetClassEnum" minOccurs="0" />
    //                 <xsd:element name="FIASSETCLASS" type="ofx:GenericNameType" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
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
    
    public virtual bool ShouldSerializeDEBTCLASS() => DEBTCLASS.HasValue;
    public virtual bool ShouldSerializeCOUPONFREQ() => COUPONFREQ.HasValue;
    public virtual bool ShouldSerializeCALLTYPE() => CALLTYPE.HasValue;
    public virtual bool ShouldSerializeASSETCLASS() => ASSETCLASS.HasValue;
}
