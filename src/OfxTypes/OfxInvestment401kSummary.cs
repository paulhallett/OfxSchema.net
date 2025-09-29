// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestment401kSummary
{
    // <xsd:complexType name="Investment401kSummary">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INV401KSUMMARY" is of type "Investment401kSummary"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("YEARTODATE")]                   public required OfxYearToDate YEARTODATE { get; set; }
    [XmlElement("INCEPTTODATE")]                 public OfxInceptToDate? INCEPTTODATE { get; set; }
    [XmlElement("PERIODTODATE")]                 public OfxPeriodToDate? PERIODTODATE { get; set; }
}
