// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentSell : OfxAbstractInvestmentTransaction
{
    // <xsd:complexType name="InvestmentSell">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVSELL" is of type "InvestmentSell"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("SECID")]                        public required OfxSecurityId SECID { get; set; }
    [XmlElement("UNITS")]                        public required OfxQuantityType UNITS { get; set; }
    [XmlElement("UNITPRICE")]                    public required OfxUnitPriceType UNITPRICE { get; set; }
    [XmlElement("MARKDOWN")]                     public OfxUnitPriceType? MARKDOWN { get; set; }
    [XmlElement("COMMISSION")]                   public OfxPositiveAmountType? COMMISSION { get; set; }
    [XmlElement("TAXES")]                        public OfxPositiveAmountType? TAXES { get; set; }
    [XmlElement("FEES")]                         public OfxPositiveAmountType? FEES { get; set; }
    [XmlElement("LOAD")]                         public OfxPositiveAmountType? LOAD { get; set; }
    [XmlElement("WITHHOLDING")]                  public OfxPositiveAmountType? WITHHOLDING { get; set; }
    [XmlElement("TAXEXEMPT")]                    public OfxBooleanType? TAXEXEMPT { get; set; }
    [XmlElement("TOTAL")]                        public required OfxAmountType TOTAL { get; set; }
    [XmlElement("GAIN")]                         public OfxAmountType? GAIN { get; set; }
    [XmlElement("CURRENCY")]                     public OfxCurrency? CURRENCY { get; set; }
    [XmlElement("ORIGCURRENCY")]                 public OfxCurrency? ORIGCURRENCY { get; set; }
    [XmlElement("SUBACCTSEC")]                   public required OfxSubAccountEnum SUBACCTSEC { get; set; }
    [XmlElement("SUBACCTFUND")]                  public required OfxSubAccountEnum SUBACCTFUND { get; set; }
    [XmlElement("LOANID")]                       public OfxLoanIdType? LOANID { get; set; }
    [XmlElement("STATEWITHHOLDING")]             public OfxPositiveAmountType? STATEWITHHOLDING { get; set; }
    [XmlElement("PENALTY")]                      public OfxPositiveAmountType? PENALTY { get; set; }
    [XmlElement("INV401KSOURCE")]                public OfxInvestment401kSourceEnum? INV401KSOURCE { get; set; }
    
    public virtual bool ShouldSerializeTAXEXEMPT() => TAXEXEMPT.HasValue;
    public virtual bool ShouldSerializeINV401KSOURCE() => INV401KSOURCE.HasValue;
}
