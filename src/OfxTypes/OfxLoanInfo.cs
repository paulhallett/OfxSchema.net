// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxLoanInfo
{
    // <xsd:complexType name="LoanInfo">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "LOANINFO" is of type "LoanInfo"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("LOANID")]                       public required OfxLoanIdType LOANID { get; set; }
    [XmlElement("LOANDESC")]                     public OfxGenericDescriptionType? LOANDESC { get; set; }
    [XmlElement("INITIALLOANBAL")]               public OfxAmountType? INITIALLOANBAL { get; set; }
    [XmlElement("LOANSTARTDATE")]                public OfxDateTimeType? LOANSTARTDATE { get; set; }
    [XmlElement("CURRENTLOANBAL")]               public required OfxAmountType CURRENTLOANBAL { get; set; }
    [XmlElement("DTASOF")]                       public required OfxDateTimeType DTASOF { get; set; }
    [XmlElement("LOANRATE")]                     public OfxRateType? LOANRATE { get; set; }
    [XmlElement("LOANPMTAMT")]                   public OfxAmountType? LOANPMTAMT { get; set; }
    [XmlElement("LOANPMTFREQ")]                  public OfxInvestmentFrequencyEnum? LOANPMTFREQ { get; set; }
    [XmlElement("LOANPMTSINITIAL")]              public OfxNumberPayments? LOANPMTSINITIAL { get; set; }
    [XmlElement("LOANPMTSREMAINING")]            public OfxNumberPayments? LOANPMTSREMAINING { get; set; }
    [XmlElement("LOANMATURITYDATE")]             public OfxDateTimeType? LOANMATURITYDATE { get; set; }
    [XmlElement("LOANTOTALPROJINTEREST")]        public OfxAmountType? LOANTOTALPROJINTEREST { get; set; }
    [XmlElement("LOANINTERESTTODATE")]           public OfxAmountType? LOANINTERESTTODATE { get; set; }
    [XmlElement("LOANNEXTPMTDATE")]              public OfxDateTimeType? LOANNEXTPMTDATE { get; set; }
}
