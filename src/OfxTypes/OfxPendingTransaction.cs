// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxPendingTransaction
{
    // <xsd:complexType name="PendingTransaction">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "STMTTRNP" is of type "PendingTransaction"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("TRNTYPE")]                      public required OfxTransactionEnum TRNTYPE { get; set; }
    [XmlElement("DTTRAN")]                       public required OfxDateTimeType DTTRAN { get; set; }
    [XmlElement("DTEXPIRE")]                     public OfxDateTimeType? DTEXPIRE { get; set; }
    [XmlElement("TRNAMT")]                       public required OfxAmountType TRNAMT { get; set; }
    [XmlElement("REFNUM")]                       public OfxReferenceNumberType? REFNUM { get; set; }
    [XmlElement("NAME")]                         public required OfxGenericNameType NAME { get; set; }
    [XmlElement("EXTDNAME")]                     public OfxExtendedNameType? EXTDNAME { get; set; }
    [XmlElement("MEMO")]                         public OfxMessageType? MEMO { get; set; }
    [XmlElement("IMAGEDATA")]                    public OfxImageData? IMAGEDATA { get; set; }
    [XmlElement("CURRENCY")]                     public required OfxCurrency CURRENCY { get; set; }
    [XmlElement("ORIGCURRENCY")]                 public required OfxCurrency ORIGCURRENCY { get; set; }
}
