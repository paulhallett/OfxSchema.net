// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxGeneralOpenOrder
{
    // <xsd:complexType name="GeneralOpenOrder">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "OO" is of type "GeneralOpenOrder"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="FITID" type="ofx:FinancialInstitutionTransactionIdType" />
    //         <xsd:element name="SRVRTID" type="ofx:ServerIdType" minOccurs="0" />
    //         <xsd:element name="SECID" type="ofx:SecurityId" />
    //         <xsd:element name="DTPLACED" type="ofx:DateTimeType" />
    //         <xsd:element name="UNITS" type="ofx:QuantityType" />
    //         <xsd:element name="SUBACCT" type="ofx:SubAccountEnum" />
    //         <xsd:element name="DURATION" type="ofx:DurationEnum" />
    //         <xsd:element name="RESTRICTION" type="ofx:RestrictionEnum" />
    //         <xsd:element name="MINUNITS" type="ofx:QuantityType" minOccurs="0" />
    //         <xsd:element name="LIMITPRICE" type="ofx:UnitPriceType" minOccurs="0" />
    //         <xsd:element name="STOPPRICE" type="ofx:UnitPriceType" minOccurs="0" />
    //         <xsd:element name="MEMO" type="ofx:MessageType" minOccurs="0" />
    //         <xsd:element name="CURRENCY" type="ofx:Currency" minOccurs="0" />
    //         <xsd:element name="INV401KSOURCE" type="ofx:Investment401kSourceEnum" minOccurs="0" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("FITID")]                        public required OfxFinancialInstitutionTransactionIdType FITID { get; set; }
    [XmlElement("SRVRTID")]                      public OfxServerIdType? SRVRTID { get; set; }
    [XmlElement("SECID")]                        public required OfxSecurityId SECID { get; set; }
    [XmlElement("DTPLACED")]                     public required OfxDateTimeType DTPLACED { get; set; }
    [XmlElement("UNITS")]                        public required OfxQuantityType UNITS { get; set; }
    [XmlElement("SUBACCT")]                      public required OfxSubAccountEnum SUBACCT { get; set; }
    [XmlElement("DURATION")]                     public required OfxDurationEnum DURATION { get; set; }
    [XmlElement("RESTRICTION")]                  public required OfxRestrictionEnum RESTRICTION { get; set; }
    [XmlElement("MINUNITS")]                     public OfxQuantityType? MINUNITS { get; set; }
    [XmlElement("LIMITPRICE")]                   public OfxUnitPriceType? LIMITPRICE { get; set; }
    [XmlElement("STOPPRICE")]                    public OfxUnitPriceType? STOPPRICE { get; set; }
    [XmlElement("MEMO")]                         public OfxMessageType? MEMO { get; set; }
    [XmlElement("CURRENCY")]                     public OfxCurrency? CURRENCY { get; set; }
    [XmlElement("INV401KSOURCE")]                public OfxInvestment401kSourceEnum? INV401KSOURCE { get; set; }
    
    public virtual bool ShouldSerializeINV401KSOURCE() => INV401KSOURCE.HasValue;
}
