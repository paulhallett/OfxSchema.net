// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentPosition
{
    // <xsd:complexType name="InvestmentPosition">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVPOS" is of type "InvestmentPosition"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("SECID")]                        public required OfxSecurityId SECID { get; set; }
    [XmlElement("HELDINACCT")]                   public required OfxSubAccountEnum HELDINACCT { get; set; }
    [XmlElement("POSTYPE")]                      public required OfxPositionTypeEnum POSTYPE { get; set; }
    [XmlElement("UNITS")]                        public required OfxQuantityType UNITS { get; set; }
    [XmlElement("UNITPRICE")]                    public required OfxUnitPriceType UNITPRICE { get; set; }
    [XmlElement("MKTVAL")]                       public required OfxAmountType MKTVAL { get; set; }
    [XmlElement("AVGCOSTBASIS")]                 public OfxAmountType? AVGCOSTBASIS { get; set; }
    [XmlElement("DTPRICEASOF")]                  public required OfxDateTimeType DTPRICEASOF { get; set; }
    [XmlElement("CURRENCY")]                     public OfxCurrency? CURRENCY { get; set; }
    [XmlElement("MEMO")]                         public OfxMessageType? MEMO { get; set; }
    [XmlElement("INV401KSOURCE")]                public OfxInvestment401kSourceEnum? INV401KSOURCE { get; set; }
}
