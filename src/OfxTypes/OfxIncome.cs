// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxIncome : OfxAbstractInvestmentTransaction
{
    // <xsd:complexType name="Income">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INCOME" is of type "Income"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractInvestmentTransaction" />
    //             <xsd:sequence>
    //                 <xsd:element name="SECID" type="ofx:SecurityId" />
    //                 <xsd:element name="INCOMETYPE" type="ofx:IncomeEnum" />
    //                 <xsd:element name="TOTAL" type="ofx:AmountType" />
    //                 <xsd:element name="SUBACCTSEC" type="ofx:SubAccountEnum" />
    //                 <xsd:element name="SUBACCTFUND" type="ofx:SubAccountEnum" />
    //                 <xsd:element name="TAXEXEMPT" type="ofx:BooleanType" minOccurs="0" />
    //                 <xsd:element name="WITHHOLDING" type="ofx:PositiveAmountType" minOccurs="0" />
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
    [XmlElement("SUBACCTFUND")]                  public required OfxSubAccountEnum SUBACCTFUND { get; set; }
    [XmlElement("TAXEXEMPT")]                    public OfxBooleanType? TAXEXEMPT { get; set; }
    [XmlElement("WITHHOLDING")]                  public OfxPositiveAmountType? WITHHOLDING { get; set; }
    [XmlElement("CURRENCY")]                     public OfxCurrency? CURRENCY { get; set; }
    [XmlElement("ORIGCURRENCY")]                 public OfxCurrency? ORIGCURRENCY { get; set; }
    [XmlElement("INV401KSOURCE")]                public OfxInvestment401kSourceEnum? INV401KSOURCE { get; set; }
    
    public virtual bool ShouldSerializeTAXEXEMPT() => TAXEXEMPT.HasValue;
    public virtual bool ShouldSerializeINV401KSOURCE() => INV401KSOURCE.HasValue;
}
