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
