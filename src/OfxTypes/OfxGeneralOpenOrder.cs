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
}
