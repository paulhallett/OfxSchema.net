// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxContributionSecurity
{
    // <xsd:complexType name="ContributionSecurity">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "CONTRIBSECURITY" is of type "ContributionSecurity"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="SECID" type="ofx:SecurityId" />
    //         <xsd:choice>
    //             <xsd:choice>
    //                 <xsd:element name="PRETAXCONTRIBPCT" type="ofx:RateType" />
    //                 <xsd:element name="AFTERTAXCONTRIBPCT" type="ofx:RateType" />
    //                 <xsd:element name="MATCHCONTRIBPCT" type="ofx:RateType" />
    //                 <xsd:element name="PROFITSHARINGCONTRIBPCT" type="ofx:RateType" />
    //                 <xsd:element name="ROLLOVERCONTRIBPCT" type="ofx:RateType" />
    //                 <xsd:element name="OTHERVESTPCT" type="ofx:RateType" />
    //                 <xsd:element name="OTHERNONVESTPCT" type="ofx:RateType" />
    //             </xsd:choice>
    //             <xsd:choice>
    //                 <xsd:element name="PRETAXCONTRIBAMT" type="ofx:AmountType" />
    //                 <xsd:element name="AFTERTAXCONTRIBAMT" type="ofx:AmountType" />
    //                 <xsd:element name="MATCHCONTRIBAMT" type="ofx:AmountType" />
    //                 <xsd:element name="PROFITSHARINGCONTRIBAMT" type="ofx:AmountType" />
    //                 <xsd:element name="ROLLOVERCONTRIBAMT" type="ofx:AmountType" />
    //                 <xsd:element name="OTHERVESTAMT" type="ofx:AmountType" />
    //                 <xsd:element name="OTHERNONVESTAMT" type="ofx:AmountType" />
    //             </xsd:choice>
    //         </xsd:choice>
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("SECID")]                        public required OfxSecurityId SECID { get; set; }
    [XmlElement("PRETAXCONTRIBPCT")]             public OfxRateType? PRETAXCONTRIBPCT { get; set; }
    [XmlElement("AFTERTAXCONTRIBPCT")]           public OfxRateType? AFTERTAXCONTRIBPCT { get; set; }
    [XmlElement("MATCHCONTRIBPCT")]              public OfxRateType? MATCHCONTRIBPCT { get; set; }
    [XmlElement("PROFITSHARINGCONTRIBPCT")]      public OfxRateType? PROFITSHARINGCONTRIBPCT { get; set; }
    [XmlElement("ROLLOVERCONTRIBPCT")]           public OfxRateType? ROLLOVERCONTRIBPCT { get; set; }
    [XmlElement("OTHERVESTPCT")]                 public OfxRateType? OTHERVESTPCT { get; set; }
    [XmlElement("OTHERNONVESTPCT")]              public OfxRateType? OTHERNONVESTPCT { get; set; }
    [XmlElement("PRETAXCONTRIBAMT")]             public OfxAmountType? PRETAXCONTRIBAMT { get; set; }
    [XmlElement("AFTERTAXCONTRIBAMT")]           public OfxAmountType? AFTERTAXCONTRIBAMT { get; set; }
    [XmlElement("MATCHCONTRIBAMT")]              public OfxAmountType? MATCHCONTRIBAMT { get; set; }
    [XmlElement("PROFITSHARINGCONTRIBAMT")]      public OfxAmountType? PROFITSHARINGCONTRIBAMT { get; set; }
    [XmlElement("ROLLOVERCONTRIBAMT")]           public OfxAmountType? ROLLOVERCONTRIBAMT { get; set; }
    [XmlElement("OTHERVESTAMT")]                 public OfxAmountType? OTHERVESTAMT { get; set; }
    [XmlElement("OTHERNONVESTAMT")]              public OfxAmountType? OTHERNONVESTAMT { get; set; }
}
