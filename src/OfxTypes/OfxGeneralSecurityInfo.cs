// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxGeneralSecurityInfo
{
    // <xsd:complexType name="GeneralSecurityInfo">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SECINFO" is of type "GeneralSecurityInfo"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="SECID" type="ofx:SecurityId" />
    //         <xsd:element name="SECNAME" type="ofx:SecurityNameType" />
    //         <xsd:element name="TICKER" type="ofx:TickerType" minOccurs="0" />
    //         <xsd:element name="FIID" type="ofx:FinancialInstitutionIdType" minOccurs="0" />
    //         <xsd:element name="RATING" type="ofx:Rating" minOccurs="0" />
    //         <xsd:element name="UNITPRICE" type="ofx:UnitPriceType" minOccurs="0" />
    //         <xsd:element name="DTASOF" type="ofx:DateTimeType" minOccurs="0" />
    //         <xsd:element name="CURRENCY" type="ofx:Currency" minOccurs="0" />
    //         <xsd:element name="MEMO" type="ofx:MessageType" minOccurs="0" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("SECID")]                        public required OfxSecurityId SECID { get; set; }
    [XmlElement("SECNAME")]                      public required OfxSecurityNameType SECNAME { get; set; }
    [XmlElement("TICKER")]                       public OfxTickerType? TICKER { get; set; }
    [XmlElement("FIID")]                         public OfxFinancialInstitutionIdType? FIID { get; set; }
    [XmlElement("RATING")]                       public OfxRating? RATING { get; set; }
    [XmlElement("UNITPRICE")]                    public OfxUnitPriceType? UNITPRICE { get; set; }
    [XmlElement("DTASOF")]                       public OfxDateTimeType? DTASOF { get; set; }
    [XmlElement("CURRENCY")]                     public OfxCurrency? CURRENCY { get; set; }
    [XmlElement("MEMO")]                         public OfxMessageType? MEMO { get; set; }
}
