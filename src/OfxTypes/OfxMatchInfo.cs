// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxMatchInfo
{
    // <xsd:complexType name="MatchInfo">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "MATCHINFO" is of type "MatchInfo"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("MATCHPCT")]                     public required OfxRateType MATCHPCT { get; set; }
    [XmlElement("MAXMATCHAMT")]                  public OfxAmountType? MAXMATCHAMT { get; set; }
    [XmlElement("MAXMATCHPCT")]                  public OfxRateType? MAXMATCHPCT { get; set; }
    [XmlElement("STARTOFYEAR")]                  public OfxDateTimeType? STARTOFYEAR { get; set; }
    [XmlElement("BASEMATCHAMT")]                 public OfxAmountType? BASEMATCHAMT { get; set; }
    [XmlElement("BASEMATCHPCT")]                 public OfxRateType? BASEMATCHPCT { get; set; }
}
