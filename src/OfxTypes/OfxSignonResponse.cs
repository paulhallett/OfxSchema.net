// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSignonResponse
{
    // <xsd:complexType name="SignonResponse">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SONRS" is of type "SignonResponse"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("STATUS")]                       public required OfxStatus STATUS { get; set; }
    [XmlElement("DTSERVER")]                     public required OfxDateTimeType DTSERVER { get; set; }
    [XmlElement("USERKEY")]                      public OfxUserKeyType? USERKEY { get; set; }
    [XmlElement("TSKEYEXPIRE")]                  public OfxDateTimeType? TSKEYEXPIRE { get; set; }
    [XmlElement("LANGUAGE")]                     public required OfxLanguageEnum LANGUAGE { get; set; }
    [XmlElement("DTPROFUP")]                     public OfxDateTimeType? DTPROFUP { get; set; }
    [XmlElement("DTUSERUP")]                     public OfxDateTimeType? DTUSERUP { get; set; }
    [XmlElement("DTACCTUP")]                     public OfxDateTimeType? DTACCTUP { get; set; }
    [XmlElement("FI")]                           public OfxFinancialInstitution? FI { get; set; }
    [XmlElement("SESSCOOKIE")]                   public OfxSessionCookieType? SESSCOOKIE { get; set; }
    [XmlElement("ACCESSKEY")]                    public OfxAccessKeyType? ACCESSKEY { get; set; }
}
