// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentBuy : OfxAbstractInvestmentTransaction
{
    // <xsd:complexType name="InvestmentBuy">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVBUY" is of type "InvestmentBuy"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("SECID")]                        public required OfxSecurityId SECID { get; set; }
    [XmlElement("UNITS")]                        public required OfxQuantityType UNITS { get; set; }
    [XmlElement("UNITPRICE")]                    public required OfxUnitPriceType UNITPRICE { get; set; }
    [XmlElement("MARKUP")]                       public OfxUnitPriceType? MARKUP { get; set; }
    [XmlElement("COMMISSION")]                   public OfxPositiveAmountType? COMMISSION { get; set; }
    [XmlElement("TAXES")]                        public OfxPositiveAmountType? TAXES { get; set; }
    [XmlElement("FEES")]                         public OfxPositiveAmountType? FEES { get; set; }
    [XmlElement("LOAD")]                         public OfxPositiveAmountType? LOAD { get; set; }
    [XmlElement("TOTAL")]                        public required OfxAmountType TOTAL { get; set; }
    [XmlElement("CURRENCY")]                     public OfxCurrency? CURRENCY { get; set; }
    [XmlElement("ORIGCURRENCY")]                 public OfxCurrency? ORIGCURRENCY { get; set; }
    [XmlElement("SUBACCTSEC")]                   public required OfxSubAccountEnum SUBACCTSEC { get; set; }
    [XmlElement("SUBACCTFUND")]                  public required OfxSubAccountEnum SUBACCTFUND { get; set; }
    [XmlElement("LOANID")]                       public required OfxLoanIdType LOANID { get; set; }
    [XmlElement("LOANPRINCIPAL")]                public required OfxAmountType LOANPRINCIPAL { get; set; }
    [XmlElement("LOANINTEREST")]                 public required OfxAmountType LOANINTEREST { get; set; }
    [XmlElement("INV401KSOURCE")]                public OfxInvestment401kSourceEnum? INV401KSOURCE { get; set; }
    [XmlElement("DTPAYROLL")]                    public OfxDateTimeType? DTPAYROLL { get; set; }
    [XmlElement("PRIORYEARCONTRIB")]             public OfxBooleanType? PRIORYEARCONTRIB { get; set; }
    
    public virtual bool ShouldSerializeINV401KSOURCE() => INV401KSOURCE.HasValue;
    public virtual bool ShouldSerializePRIORYEARCONTRIB() => PRIORYEARCONTRIB.HasValue;
}
