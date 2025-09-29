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
    // </xsd:complexType>
    
    [XmlElement("SECID")]                        public required OfxSecurityId SECID { get; set; }
    [XmlElement("PRETAXCONTRIBPCT")]             public required OfxRateType PRETAXCONTRIBPCT { get; set; }
    [XmlElement("AFTERTAXCONTRIBPCT")]           public required OfxRateType AFTERTAXCONTRIBPCT { get; set; }
    [XmlElement("MATCHCONTRIBPCT")]              public required OfxRateType MATCHCONTRIBPCT { get; set; }
    [XmlElement("PROFITSHARINGCONTRIBPCT")]      public required OfxRateType PROFITSHARINGCONTRIBPCT { get; set; }
    [XmlElement("ROLLOVERCONTRIBPCT")]           public required OfxRateType ROLLOVERCONTRIBPCT { get; set; }
    [XmlElement("OTHERVESTPCT")]                 public required OfxRateType OTHERVESTPCT { get; set; }
    [XmlElement("OTHERNONVESTPCT")]              public required OfxRateType OTHERNONVESTPCT { get; set; }
    [XmlElement("PRETAXCONTRIBAMT")]             public required OfxAmountType PRETAXCONTRIBAMT { get; set; }
    [XmlElement("AFTERTAXCONTRIBAMT")]           public required OfxAmountType AFTERTAXCONTRIBAMT { get; set; }
    [XmlElement("MATCHCONTRIBAMT")]              public required OfxAmountType MATCHCONTRIBAMT { get; set; }
    [XmlElement("PROFITSHARINGCONTRIBAMT")]      public required OfxAmountType PROFITSHARINGCONTRIBAMT { get; set; }
    [XmlElement("ROLLOVERCONTRIBAMT")]           public required OfxAmountType ROLLOVERCONTRIBAMT { get; set; }
    [XmlElement("OTHERVESTAMT")]                 public required OfxAmountType OTHERVESTAMT { get; set; }
    [XmlElement("OTHERNONVESTAMT")]              public required OfxAmountType OTHERNONVESTAMT { get; set; }
}
