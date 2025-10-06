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
    //     <xsd:sequence>
    //         <xsd:element name="YEARTODATE" type="ofx:YearToDate" />
    //         <xsd:element name="INCEPTTODATE" type="ofx:InceptToDate" minOccurs="0" />
    //         <xsd:element name="PERIODTODATE" type="ofx:PeriodToDate" minOccurs="0" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("YEARTODATE")]                   public required OfxYearToDate YEARTODATE { get; set; }
    [XmlElement("INCEPTTODATE")]                 public OfxInceptToDate? INCEPTTODATE { get; set; }
    [XmlElement("PERIODTODATE")]                 public OfxPeriodToDate? PERIODTODATE { get; set; }
}
