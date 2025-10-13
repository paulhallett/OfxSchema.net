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
    //     <xsd:sequence>
    //         <xsd:element name="SECID" type="ofx:SecurityId" />
    //         <xsd:element name="HELDINACCT" type="ofx:SubAccountEnum" />
    //         <xsd:element name="POSTYPE" type="ofx:PositionTypeEnum" />
    //         <xsd:element name="UNITS" type="ofx:QuantityType" />
    //         <xsd:element name="UNITPRICE" type="ofx:UnitPriceType" />
    //         <xsd:element name="MKTVAL" type="ofx:AmountType" />
    //         <xsd:element name="AVGCOSTBASIS" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="DTPRICEASOF" type="ofx:DateTimeType" />
    //         <xsd:element name="CURRENCY" type="ofx:Currency" minOccurs="0" />
    //         <xsd:element name="MEMO" type="ofx:MessageType" minOccurs="0" />
    //         <xsd:element name="INV401KSOURCE" type="ofx:Investment401kSourceEnum" minOccurs="0" />
    //     </xsd:sequence>
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
    
    public virtual bool ShouldSerializeINV401KSOURCE() => INV401KSOURCE.HasValue;
}
