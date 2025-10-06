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
    //     <xsd:sequence>
    //         <xsd:element name="MATCHPCT" type="ofx:RateType" />
    //         <xsd:element name="MAXMATCHAMT" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="MAXMATCHPCT" type="ofx:RateType" minOccurs="0" />
    //         <xsd:element name="STARTOFYEAR" type="ofx:DateTimeType" minOccurs="0" />
    //         <xsd:element name="BASEMATCHAMT" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="BASEMATCHPCT" type="ofx:RateType" minOccurs="0" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("MATCHPCT")]                     public required OfxRateType MATCHPCT { get; set; }
    [XmlElement("MAXMATCHAMT")]                  public OfxAmountType? MAXMATCHAMT { get; set; }
    [XmlElement("MAXMATCHPCT")]                  public OfxRateType? MAXMATCHPCT { get; set; }
    [XmlElement("STARTOFYEAR")]                  public OfxDateTimeType? STARTOFYEAR { get; set; }
    [XmlElement("BASEMATCHAMT")]                 public OfxAmountType? BASEMATCHAMT { get; set; }
    [XmlElement("BASEMATCHPCT")]                 public OfxRateType? BASEMATCHPCT { get; set; }
}
