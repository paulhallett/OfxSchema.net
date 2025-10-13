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
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractInvestmentTransaction" />
    //             <xsd:sequence>
    //                 <xsd:element name="SECID" type="ofx:SecurityId" />
    //                 <xsd:element name="INCOMETYPE" type="ofx:IncomeEnum" />
    //                 <xsd:element name="TOTAL" type="ofx:AmountType" />
    //                 <xsd:element name="SUBACCTSEC" type="ofx:SubAccountEnum" />
    //                 <xsd:element name="UNITS" type="ofx:QuantityType" />
    //                 <xsd:element name="UNITPRICE" type="ofx:UnitPriceType" />
    //                 <xsd:element name="COMMISSION" type="ofx:PositiveAmountType" minOccurs="0" />
    //                 <xsd:element name="TAXES" type="ofx:PositiveAmountType" minOccurs="0" />
    //                 <xsd:element name="FEES" type="ofx:PositiveAmountType" minOccurs="0" />
    //                 <xsd:element name="LOAD" type="ofx:PositiveAmountType" minOccurs="0" />
    //                 <xsd:element name="TAXEXEMPT" type="ofx:BooleanType" minOccurs="0" />
    //                 <xsd:element name="CURRENCY" type="ofx:Currency" minOccurs="0" />
    //                 <xsd:element name="ORIGCURRENCY" type="ofx:Currency" minOccurs="0" />
    //                 <xsd:element name="INV401KSOURCE" type="ofx:Investment401kSourceEnum" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
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
    
    public virtual bool ShouldSerializeTAXEXEMPT() => TAXEXEMPT.HasValue;
    public virtual bool ShouldSerializeINV401KSOURCE() => INV401KSOURCE.HasValue;
}
