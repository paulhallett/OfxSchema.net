// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestment401kBalance
{
    // <xsd:complexType name="Investment401kBalance">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INV401KBAL" is of type "Investment401kBalance"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="CASHBAL" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="PRETAX" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="AFTERTAX" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="MATCH" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="PROFITSHARING" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="ROLLOVER" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="OTHERVEST" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="OTHERNONVEST" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="TOTAL" type="ofx:AmountType" />
    //         <xsd:element name="BALLIST" type="ofx:BalanceList" minOccurs="0" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("CASHBAL")]                      public OfxAmountType? CASHBAL { get; set; }
    [XmlElement("PRETAX")]                       public OfxAmountType? PRETAX { get; set; }
    [XmlElement("AFTERTAX")]                     public OfxAmountType? AFTERTAX { get; set; }
    [XmlElement("MATCH")]                        public OfxAmountType? MATCH { get; set; }
    [XmlElement("PROFITSHARING")]                public OfxAmountType? PROFITSHARING { get; set; }
    [XmlElement("ROLLOVER")]                     public OfxAmountType? ROLLOVER { get; set; }
    [XmlElement("OTHERVEST")]                    public OfxAmountType? OTHERVEST { get; set; }
    [XmlElement("OTHERNONVEST")]                 public OfxAmountType? OTHERNONVEST { get; set; }
    [XmlElement("TOTAL")]                        public required OfxAmountType TOTAL { get; set; }
    [XmlElement("BALLIST")]                      public OfxBalanceList? BALLIST { get; set; }
}
