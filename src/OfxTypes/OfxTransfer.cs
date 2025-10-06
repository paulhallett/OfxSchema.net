// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxTransfer : OfxAbstractInvestmentTransaction
{
    // <xsd:complexType name="Transfer">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "TRANSFER" is of type "Transfer"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractInvestmentTransaction" />
    //             <xsd:sequence>
    //                 <xsd:element name="SECID" type="ofx:SecurityId" />
    //                 <xsd:element name="SUBACCTSEC" type="ofx:SubAccountEnum" />
    //                 <xsd:element name="UNITS" type="ofx:QuantityType" />
    //                 <xsd:element name="TFERACTION" type="ofx:InOutEnum" />
    //                 <xsd:element name="POSTYPE" type="ofx:PositionTypeEnum" />
    //                 <xsd:element name="INVACCTFROM" type="ofx:InvestmentAccount" minOccurs="0" />
    //                 <xsd:element name="AVGCOSTBASIS" type="ofx:AmountType" minOccurs="0" />
    //                 <xsd:element name="UNITPRICE" type="ofx:UnitPriceType" minOccurs="0" />
    //                 <xsd:element name="DTPURCHASE" type="ofx:DateTimeType" minOccurs="0" />
    //                 <xsd:element name="INV401KSOURCE" type="ofx:Investment401kSourceEnum" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("SECID")]                        public required OfxSecurityId SECID { get; set; }
    [XmlElement("SUBACCTSEC")]                   public required OfxSubAccountEnum SUBACCTSEC { get; set; }
    [XmlElement("UNITS")]                        public required OfxQuantityType UNITS { get; set; }
    [XmlElement("TFERACTION")]                   public required OfxInOutEnum TFERACTION { get; set; }
    [XmlElement("POSTYPE")]                      public required OfxPositionTypeEnum POSTYPE { get; set; }
    [XmlElement("INVACCTFROM")]                  public OfxInvestmentAccount? INVACCTFROM { get; set; }
    [XmlElement("AVGCOSTBASIS")]                 public OfxAmountType? AVGCOSTBASIS { get; set; }
    [XmlElement("UNITPRICE")]                    public OfxUnitPriceType? UNITPRICE { get; set; }
    [XmlElement("DTPURCHASE")]                   public OfxDateTimeType? DTPURCHASE { get; set; }
    [XmlElement("INV401KSOURCE")]                public OfxInvestment401kSourceEnum? INV401KSOURCE { get; set; }
    
    public virtual bool ShouldSerializeINV401KSOURCE() => INV401KSOURCE.HasValue;
}
