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
    //     <xsd:sequence>
    //         <xsd:element name="STATUS" type="ofx:Status" />
    //         <xsd:element name="DTSERVER" type="ofx:DateTimeType" />
    //         <xsd:element name="USERKEY" type="ofx:UserKeyType" minOccurs="0" />
    //         <xsd:element name="TSKEYEXPIRE" type="ofx:DateTimeType" minOccurs="0" />
    //         <xsd:element name="LANGUAGE" type="ofx:LanguageEnum" />
    //         <xsd:element name="DTPROFUP" type="ofx:DateTimeType" minOccurs="0" />
    //         <xsd:element name="DTUSERUP" type="ofx:DateTimeType" minOccurs="0" />
    //         <xsd:element name="DTACCTUP" type="ofx:DateTimeType" minOccurs="0" />
    //         <xsd:element name="FI" type="ofx:FinancialInstitution" minOccurs="0" />
    //         <xsd:element name="SESSCOOKIE" type="ofx:SessionCookieType" minOccurs="0" />
    //         <xsd:element name="ACCESSKEY" type="ofx:AccessKeyType" minOccurs="0" />
    //         <xsd:element name="OFXEXTENSION" type="ofx:OFXExtensionType" minOccurs="0" />
    //     </xsd:sequence>
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
