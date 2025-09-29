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
}
