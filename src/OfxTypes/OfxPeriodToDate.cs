// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxPeriodToDate
{
    // <xsd:complexType name="PeriodToDate">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "PERIODTODATE" is of type "PeriodToDate"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("DTSTART")]                      public required OfxDateTimeType DTSTART { get; set; }
    [XmlElement("DTEND")]                        public required OfxDateTimeType DTEND { get; set; }
    [XmlElement("CONTRIBUTIONS")]                public OfxContributions? CONTRIBUTIONS { get; set; }
    [XmlElement("WITHDRAWALS")]                  public OfxWithdrawals? WITHDRAWALS { get; set; }
    [XmlElement("EARNINGS")]                     public OfxEarnings? EARNINGS { get; set; }
}
