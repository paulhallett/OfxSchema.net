// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxBalance
{
    // <xsd:complexType name="Balance">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "BAL" is of type "Balance"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="NAME" type="ofx:GenericNameType" />
    //         <xsd:element name="DESC" type="ofx:ShortMessageType" />
    //         <xsd:element name="BALTYPE" type="ofx:BalanceEnum" />
    //         <xsd:element name="VALUE" type="ofx:AmountType" />
    //         <xsd:element name="DTASOF" type="ofx:DateTimeType" minOccurs="0" />
    //         <xsd:element name="CURRENCY" type="ofx:Currency" minOccurs="0" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("NAME")]                         public required OfxGenericNameType NAME { get; set; }
    [XmlElement("DESC")]                         public required OfxShortMessageType DESC { get; set; }
    [XmlElement("BALTYPE")]                      public required OfxBalanceEnum BALTYPE { get; set; }
    [XmlElement("VALUE")]                        public required OfxAmountType VALUE { get; set; }
    [XmlElement("DTASOF")]                       public OfxDateTimeType? DTASOF { get; set; }
    [XmlElement("CURRENCY")]                     public OfxCurrency? CURRENCY { get; set; }
}
