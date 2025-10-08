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
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractInvestmentTransaction" />
    //             <xsd:sequence>
    //                 <xsd:element name="SECID" type="ofx:SecurityId" />
    //                 <xsd:element name="UNITS" type="ofx:QuantityType" />
    //                 <xsd:element name="UNITPRICE" type="ofx:UnitPriceType" />
    //                 <xsd:element name="MARKUP" type="ofx:UnitPriceType" minOccurs="0" />
    //                 <xsd:element name="COMMISSION" type="ofx:PositiveAmountType" minOccurs="0" />
    //                 <xsd:element name="TAXES" type="ofx:PositiveAmountType" minOccurs="0" />
    //                 <xsd:element name="FEES" type="ofx:PositiveAmountType" minOccurs="0" />
    //                 <xsd:element name="LOAD" type="ofx:PositiveAmountType" minOccurs="0" />
    //                 <xsd:element name="TOTAL" type="ofx:AmountType" />
    //                 <xsd:element name="CURRENCY" type="ofx:Currency" minOccurs="0" />
    //                 <xsd:element name="ORIGCURRENCY" type="ofx:Currency" minOccurs="0" />
    //                 <xsd:element name="SUBACCTSEC" type="ofx:SubAccountEnum" />
    //                 <xsd:element name="SUBACCTFUND" type="ofx:SubAccountEnum" />
    //                 <xsd:sequence minOccurs="0">
    //                     <xsd:element name="LOANID" type="ofx:LoanIdType" />
    //                     <xsd:element name="LOANPRINCIPAL" type="ofx:AmountType" />
    //                     <xsd:element name="LOANINTEREST" type="ofx:AmountType" />
    //                 </xsd:sequence>
    //                 <xsd:element name="INV401KSOURCE" type="ofx:Investment401kSourceEnum" minOccurs="0" />
    //                 <xsd:element name="DTPAYROLL" type="ofx:DateTimeType" minOccurs="0" />
    //                 <xsd:element name="PRIORYEARCONTRIB" type="ofx:BooleanType" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
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
    [XmlElement("LOANID")]                       public OfxLoanIdType? LOANID { get; set; }
    [XmlElement("LOANPRINCIPAL")]                public OfxAmountType? LOANPRINCIPAL { get; set; }
    [XmlElement("LOANINTEREST")]                 public OfxAmountType? LOANINTEREST { get; set; }
    [XmlElement("INV401KSOURCE")]                public OfxInvestment401kSourceEnum? INV401KSOURCE { get; set; }
    [XmlElement("DTPAYROLL")]                    public OfxDateTimeType? DTPAYROLL { get; set; }
    [XmlElement("PRIORYEARCONTRIB")]             public OfxBooleanType? PRIORYEARCONTRIB { get; set; }
    
    public virtual bool ShouldSerializeINV401KSOURCE() => INV401KSOURCE.HasValue;
    public virtual bool ShouldSerializePRIORYEARCONTRIB() => PRIORYEARCONTRIB.HasValue;
}
