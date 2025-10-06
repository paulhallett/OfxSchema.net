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
    //     <xsd:sequence>
    //         <xsd:element name="TRNTYPE" type="ofx:TransactionEnum" />
    //         <xsd:element name="DTPOSTED" type="ofx:DateTimeType" />
    //         <xsd:element name="DTUSER" type="ofx:DateTimeType" minOccurs="0" />
    //         <xsd:element name="DTAVAIL" type="ofx:DateTimeType" minOccurs="0" />
    //         <xsd:element name="TRNAMT" type="ofx:AmountType" />
    //         <xsd:element name="LOANPMTINFO" type="ofx:LoanPaymentInfo" minOccurs="0" />
    //         <xsd:element name="FITID" type="ofx:FinancialInstitutionTransactionIdType" />
    //         <xsd:sequence minOccurs="0">
    //             <xsd:element name="CORRECTFITID" type="ofx:FinancialInstitutionTransactionIdType" />
    //             <xsd:element name="CORRECTACTION" type="ofx:CorrectiveActionEnum" />
    //         </xsd:sequence>
    //         <xsd:element name="SRVRTID" type="ofx:ServerIdType" minOccurs="0" />
    //         <xsd:element name="CHECKNUM" type="ofx:CheckNumberType" minOccurs="0" />
    //         <xsd:element name="REFNUM" type="ofx:ReferenceNumberType" minOccurs="0" />
    //         <xsd:element name="SIC" type="ofx:StandardIndustryCodeType" minOccurs="0" />
    //         <xsd:element name="PAYEEID" type="ofx:PayeeIdType" minOccurs="0" />
    //         <xsd:choice minOccurs="0">
    //             <xsd:element name="NAME" type="ofx:GenericNameType" />
    //             <xsd:element name="PAYEE" type="ofx:Payee" />
    //         </xsd:choice>
    //         <xsd:element name="EXTDNAME" type="ofx:ExtendedNameType" minOccurs="0" />
    //         <xsd:choice minOccurs="0">
    //             <xsd:element name="BANKACCTTO" type="ofx:BankAccount" />
    //             <xsd:element name="CCACCTTO" type="ofx:CreditCardAccount" />
    //         </xsd:choice>
    //         <xsd:element name="MEMO" type="ofx:MessageType" minOccurs="0" />
    //         <xsd:element name="IMAGEDATA" type="ofx:ImageData" minOccurs="0" maxOccurs="2" />
    //         <xsd:choice minOccurs="0">
    //             <xsd:element name="CURRENCY" type="ofx:Currency" />
    //             <xsd:element name="ORIGCURRENCY" type="ofx:Currency" />
    //         </xsd:choice>
    //         <xsd:element name="INV401KSOURCE" type="ofx:Investment401kSourceEnum" minOccurs="0" />
    //     </xsd:sequence>
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
    [XmlElement("NAME")]                         public OfxGenericNameType? NAME { get; set; }
    [XmlElement("PAYEE")]                        public OfxPayee? PAYEE { get; set; }
    [XmlElement("EXTDNAME")]                     public OfxExtendedNameType? EXTDNAME { get; set; }
    [XmlElement("BANKACCTTO")]                   public OfxBankAccount? BANKACCTTO { get; set; }
    [XmlElement("CCACCTTO")]                     public OfxCreditCardAccount? CCACCTTO { get; set; }
    [XmlElement("MEMO")]                         public OfxMessageType? MEMO { get; set; }
    [XmlElement("IMAGEDATA")]                    public List<OfxImageData>? IMAGEDATA { get; set; }
    [XmlElement("CURRENCY")]                     public OfxCurrency? CURRENCY { get; set; }
    [XmlElement("ORIGCURRENCY")]                 public OfxCurrency? ORIGCURRENCY { get; set; }
    [XmlElement("INV401KSOURCE")]                public OfxInvestment401kSourceEnum? INV401KSOURCE { get; set; }
    
    public virtual bool ShouldSerializeINV401KSOURCE() => INV401KSOURCE.HasValue;
}
