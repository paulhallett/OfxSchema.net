// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentBalance
{
    // <xsd:complexType name="InvestmentBalance">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVBAL" is of type "InvestmentBalance"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="AVAILCASH" type="ofx:AmountType" />
    //         <xsd:element name="MARGINBALANCE" type="ofx:AmountType" />
    //         <xsd:element name="SHORTBALANCE" type="ofx:AmountType" />
    //         <xsd:element name="BUYPOWER" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="BALLIST" type="ofx:BalanceList" minOccurs="0" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("AVAILCASH")]                    public required OfxAmountType AVAILCASH { get; set; }
    [XmlElement("MARGINBALANCE")]                public required OfxAmountType MARGINBALANCE { get; set; }
    [XmlElement("SHORTBALANCE")]                 public required OfxAmountType SHORTBALANCE { get; set; }
    [XmlElement("BUYPOWER")]                     public OfxAmountType? BUYPOWER { get; set; }
    [XmlElement("BALLIST")]                      public OfxBalanceList? BALLIST { get; set; }
}
