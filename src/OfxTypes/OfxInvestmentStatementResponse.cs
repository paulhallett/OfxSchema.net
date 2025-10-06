// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentStatementResponse
{
    // <xsd:complexType name="InvestmentStatementResponse">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVSTMTRS" is of type "InvestmentStatementResponse"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="DTASOF" type="ofx:DateTimeType" />
    //         <xsd:element name="CURDEF" type="ofx:CurrencyEnum" />
    //         <xsd:element name="INVACCTFROM" type="ofx:InvestmentAccount" />
    //         <xsd:element name="INVTRANLIST" type="ofx:InvestmentTransactionList" minOccurs="0" />
    //         <xsd:element name="INVPOSLIST" type="ofx:InvestmentPositionList" minOccurs="0" />
    //         <xsd:element name="INVBAL" type="ofx:InvestmentBalance" minOccurs="0" />
    //         <xsd:element name="INVOOLIST" type="ofx:InvestmentOpenOrderList" minOccurs="0" />
    //         <xsd:element name="MKTGINFO" type="ofx:InfoType" minOccurs="0" />
    //         <xsd:element name="INV401K" type="ofx:Investment401k" minOccurs="0" />
    //         <xsd:element name="INV401KBAL" type="ofx:Investment401kBalance" minOccurs="0" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("DTASOF")]                       public required OfxDateTimeType DTASOF { get; set; }
    [XmlElement("CURDEF")]                       public required OfxCurrencyEnum CURDEF { get; set; }
    [XmlElement("INVACCTFROM")]                  public required OfxInvestmentAccount INVACCTFROM { get; set; }
    [XmlElement("INVTRANLIST")]                  public OfxInvestmentTransactionList? INVTRANLIST { get; set; }
    [XmlElement("INVPOSLIST")]                   public OfxInvestmentPositionList? INVPOSLIST { get; set; }
    [XmlElement("INVBAL")]                       public OfxInvestmentBalance? INVBAL { get; set; }
    [XmlElement("INVOOLIST")]                    public OfxInvestmentOpenOrderList? INVOOLIST { get; set; }
    [XmlElement("MKTGINFO")]                     public OfxInfoType? MKTGINFO { get; set; }
    [XmlElement("INV401K")]                      public OfxInvestment401k? INV401K { get; set; }
    [XmlElement("INV401KBAL")]                   public OfxInvestment401kBalance? INV401KBAL { get; set; }
}
