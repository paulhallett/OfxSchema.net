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
    //     <xsd:sequence>
    //         <xsd:element name="EMPLOYERNAME" type="ofx:GenericNameType" />
    //         <xsd:element name="PLANID" type="ofx:IdType" minOccurs="0" />
    //         <xsd:element name="PLANJOINDATE" type="ofx:DateTimeType" minOccurs="0" />
    //         <xsd:element name="EMPLOYERCONTACTINFO" type="ofx:GenericContactInfoType" minOccurs="0" />
    //         <xsd:element name="BROKERCONTACTINFO" type="ofx:GenericContactInfoType" minOccurs="0" />
    //         <xsd:element name="DEFERPCTPRETAX" type="ofx:RateType" minOccurs="0" />
    //         <xsd:element name="DEFERPCTAFTERTAX" type="ofx:RateType" minOccurs="0" />
    //         <xsd:element name="MATCHINFO" type="ofx:MatchInfo" minOccurs="0" />
    //         <xsd:element name="CONTRIBINFO" type="ofx:ContributionInfo" minOccurs="0" />
    //         <xsd:element name="CURRENTVESTPCT" type="ofx:RateType" minOccurs="0" />
    //         <xsd:element name="VESTINFO" type="ofx:VestInfo" minOccurs="0" maxOccurs="unbounded" />
    //         <xsd:element name="LOANINFO" type="ofx:LoanInfo" minOccurs="0" maxOccurs="unbounded" />
    //         <xsd:element name="INV401KSUMMARY" type="ofx:Investment401kSummary" minOccurs="0" />
    //     </xsd:sequence>
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
    [XmlElement("VESTINFO")]                     public List<OfxVestInfo>? VESTINFO { get; set; }
    [XmlElement("LOANINFO")]                     public List<OfxLoanInfo>? LOANINFO { get; set; }
    [XmlElement("INV401KSUMMARY")]               public OfxInvestment401kSummary? INV401KSUMMARY { get; set; }
}
