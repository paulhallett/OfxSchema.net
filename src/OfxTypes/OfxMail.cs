// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxMail
{
    // <xsd:complexType name="Mail">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "MAIL" is of type "Mail"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("USERID")]                       public required OfxIdType USERID { get; set; }
    [XmlElement("DTCREATED")]                    public required OfxDateTimeType DTCREATED { get; set; }
    [XmlElement("FROM")]                         public required OfxGenericNameType FROM { get; set; }
    [XmlElement("TO")]                           public required OfxGenericNameType TO { get; set; }
    [XmlElement("SUBJECT")]                      public required OfxSubjectType SUBJECT { get; set; }
    [XmlElement("MSGBODY")]                      public required OfxMessageBodyType MSGBODY { get; set; }
    [XmlElement("INCIMAGES")]                    public required OfxBooleanType INCIMAGES { get; set; }
    [XmlElement("USEHTML")]                      public required OfxBooleanType USEHTML { get; set; }
}
