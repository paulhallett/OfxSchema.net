// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxStatementTransaction
{
    // <xsd:complexType name="StatementTransaction">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "STMTTRN" is of type "StatementTransaction"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("TRNTYPE")]                      public required OfxTransactionEnum TRNTYPE { get; set; }
    [XmlElement("DTPOSTED")]                     public required OfxDateTimeType DTPOSTED { get; set; }
    [XmlElement("DTUSER")]                       public OfxDateTimeType? DTUSER { get; set; }
    [XmlElement("DTAVAIL")]                      public OfxDateTimeType? DTAVAIL { get; set; }
    [XmlElement("TRNAMT")]                       public required OfxAmountType TRNAMT { get; set; }
    [XmlElement("LOANPMTINFO")]                  public OfxLoanPaymentInfo? LOANPMTINFO { get; set; }
    [XmlElement("FITID")]                        public required OfxFinancialInstitutionTransactionIdType FITID { get; set; }
    [XmlElement("CORRECTFITID")]                 public required OfxFinancialInstitutionTransactionIdType CORRECTFITID { get; set; }
    [XmlElement("CORRECTACTION")]                public required OfxCorrectiveActionEnum CORRECTACTION { get; set; }
    [XmlElement("SRVRTID")]                      public OfxServerIdType? SRVRTID { get; set; }
    [XmlElement("CHECKNUM")]                     public OfxCheckNumberType? CHECKNUM { get; set; }
    [XmlElement("REFNUM")]                       public OfxReferenceNumberType? REFNUM { get; set; }
    [XmlElement("SIC")]                          public OfxStandardIndustryCodeType? SIC { get; set; }
    [XmlElement("PAYEEID")]                      public OfxPayeeIdType? PAYEEID { get; set; }
    [XmlElement("NAME")]                         public required OfxGenericNameType NAME { get; set; }
    [XmlElement("PAYEE")]                        public required OfxPayee PAYEE { get; set; }
    [XmlElement("EXTDNAME")]                     public OfxExtendedNameType? EXTDNAME { get; set; }
    [XmlElement("BANKACCTTO")]                   public required OfxBankAccount BANKACCTTO { get; set; }
    [XmlElement("CCACCTTO")]                     public required OfxCreditCardAccount CCACCTTO { get; set; }
    [XmlElement("MEMO")]                         public OfxMessageType? MEMO { get; set; }
    [XmlElement("IMAGEDATA")]                    public List<OfxImageData>? IMAGEDATA { get; set; }
    [XmlElement("CURRENCY")]                     public required OfxCurrency CURRENCY { get; set; }
    [XmlElement("ORIGCURRENCY")]                 public required OfxCurrency ORIGCURRENCY { get; set; }
    [XmlElement("INV401KSOURCE")]                public OfxInvestment401kSourceEnum? INV401KSOURCE { get; set; }
    
    public virtual bool ShouldSerializeINV401KSOURCE() => INV401KSOURCE.HasValue;
}
