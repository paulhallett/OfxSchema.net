// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInceptToDate
{
    // <xsd:complexType name="InceptToDate">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INCEPTTODATE" is of type "InceptToDate"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="DTSTART" type="ofx:DateTimeType" />
    //         <xsd:element name="DTEND" type="ofx:DateTimeType" />
    //         <xsd:element name="CONTRIBUTIONS" type="ofx:Contributions" minOccurs="0" />
    //         <xsd:element name="WITHDRAWALS" type="ofx:Withdrawals" minOccurs="0" />
    //         <xsd:element name="EARNINGS" type="ofx:Earnings" minOccurs="0" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("DTSTART")]                      public required OfxDateTimeType DTSTART { get; set; }
    [XmlElement("DTEND")]                        public required OfxDateTimeType DTEND { get; set; }
    [XmlElement("CONTRIBUTIONS")]                public OfxContributions? CONTRIBUTIONS { get; set; }
    [XmlElement("WITHDRAWALS")]                  public OfxWithdrawals? WITHDRAWALS { get; set; }
    [XmlElement("EARNINGS")]                     public OfxEarnings? EARNINGS { get; set; }
}
