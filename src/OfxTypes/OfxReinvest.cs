// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxReinvest : OfxAbstractInvestmentTransaction
{
    // <xsd:complexType name="Reinvest">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "REINVEST" is of type "Reinvest"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("SECID")]                        public required OfxSecurityId SECID { get; set; }
    [XmlElement("INCOMETYPE")]                   public required OfxIncomeEnum INCOMETYPE { get; set; }
    [XmlElement("TOTAL")]                        public required OfxAmountType TOTAL { get; set; }
    [XmlElement("SUBACCTSEC")]                   public required OfxSubAccountEnum SUBACCTSEC { get; set; }
    [XmlElement("UNITS")]                        public required OfxQuantityType UNITS { get; set; }
    [XmlElement("UNITPRICE")]                    public required OfxUnitPriceType UNITPRICE { get; set; }
    [XmlElement("COMMISSION")]                   public OfxPositiveAmountType? COMMISSION { get; set; }
    [XmlElement("TAXES")]                        public OfxPositiveAmountType? TAXES { get; set; }
    [XmlElement("FEES")]                         public OfxPositiveAmountType? FEES { get; set; }
    [XmlElement("LOAD")]                         public OfxPositiveAmountType? LOAD { get; set; }
    [XmlElement("TAXEXEMPT")]                    public OfxBooleanType? TAXEXEMPT { get; set; }
    [XmlElement("CURRENCY")]                     public OfxCurrency? CURRENCY { get; set; }
    [XmlElement("ORIGCURRENCY")]                 public OfxCurrency? ORIGCURRENCY { get; set; }
    [XmlElement("INV401KSOURCE")]                public OfxInvestment401kSourceEnum? INV401KSOURCE { get; set; }
}
