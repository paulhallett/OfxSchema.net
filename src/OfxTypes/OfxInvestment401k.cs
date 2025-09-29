// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestment401k
{
    // <xsd:complexType name="Investment401k">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INV401K" is of type "Investment401k"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("EMPLOYERNAME")]                 public required OfxGenericNameType EMPLOYERNAME { get; set; }
    [XmlElement("PLANID")]                       public OfxIdType? PLANID { get; set; }
    [XmlElement("PLANJOINDATE")]                 public OfxDateTimeType? PLANJOINDATE { get; set; }
    [XmlElement("EMPLOYERCONTACTINFO")]          public OfxGenericContactInfoType? EMPLOYERCONTACTINFO { get; set; }
    [XmlElement("BROKERCONTACTINFO")]            public OfxGenericContactInfoType? BROKERCONTACTINFO { get; set; }
    [XmlElement("DEFERPCTPRETAX")]               public OfxRateType? DEFERPCTPRETAX { get; set; }
    [XmlElement("DEFERPCTAFTERTAX")]             public OfxRateType? DEFERPCTAFTERTAX { get; set; }
    [XmlElement("MATCHINFO")]                    public OfxMatchInfo? MATCHINFO { get; set; }
    [XmlElement("CONTRIBINFO")]                  public OfxContributionInfo? CONTRIBINFO { get; set; }
    [XmlElement("CURRENTVESTPCT")]               public OfxRateType? CURRENTVESTPCT { get; set; }
    [XmlElement("VESTINFO")]                     public OfxVestInfo? VESTINFO { get; set; }
    [XmlElement("LOANINFO")]                     public OfxLoanInfo? LOANINFO { get; set; }
    [XmlElement("INV401KSUMMARY")]               public OfxInvestment401kSummary? INV401KSUMMARY { get; set; }
}
