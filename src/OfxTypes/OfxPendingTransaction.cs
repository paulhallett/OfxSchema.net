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
    //     <xsd:sequence>
    //         <xsd:element name="TRNTYPE" type="ofx:TransactionEnum" />
    //         <xsd:element name="DTTRAN" type="ofx:DateTimeType" />
    //         <xsd:element name="DTEXPIRE" type="ofx:DateTimeType" minOccurs="0" />
    //         <xsd:element name="TRNAMT" type="ofx:AmountType" />
    //         <xsd:element name="REFNUM" type="ofx:ReferenceNumberType" minOccurs="0" />
    //         <xsd:element name="NAME" type="ofx:GenericNameType" />
    //         <xsd:element name="EXTDNAME" type="ofx:ExtendedNameType" minOccurs="0" />
    //         <xsd:element name="MEMO" type="ofx:MessageType" minOccurs="0" />
    //         <xsd:element name="IMAGEDATA" type="ofx:ImageData" minOccurs="0" maxOccurs="2" />
    //         <xsd:choice minOccurs="0">
    //             <xsd:element name="CURRENCY" type="ofx:Currency" />
    //             <xsd:element name="ORIGCURRENCY" type="ofx:Currency" />
    //         </xsd:choice>
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("TRNTYPE")]                      public required OfxTransactionEnum TRNTYPE { get; set; }
    [XmlElement("DTTRAN")]                       public required OfxDateTimeType DTTRAN { get; set; }
    [XmlElement("DTEXPIRE")]                     public OfxDateTimeType? DTEXPIRE { get; set; }
    [XmlElement("TRNAMT")]                       public required OfxAmountType TRNAMT { get; set; }
    [XmlElement("REFNUM")]                       public OfxReferenceNumberType? REFNUM { get; set; }
    [XmlElement("NAME")]                         public required OfxGenericNameType NAME { get; set; }
    [XmlElement("EXTDNAME")]                     public OfxExtendedNameType? EXTDNAME { get; set; }
    [XmlElement("MEMO")]                         public OfxMessageType? MEMO { get; set; }
    [XmlElement("IMAGEDATA")]                    public List<OfxImageData>? IMAGEDATA { get; set; }
    [XmlElement("CURRENCY")]                     public OfxCurrency? CURRENCY { get; set; }
    [XmlElement("ORIGCURRENCY")]                 public OfxCurrency? ORIGCURRENCY { get; set; }
}
