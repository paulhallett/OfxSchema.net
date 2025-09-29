// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentExpense : OfxAbstractInvestmentTransaction
{
    // <xsd:complexType name="InvestmentExpense">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVEXPENSE" is of type "InvestmentExpense"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("SECID")]                        public required OfxSecurityId SECID { get; set; }
    [XmlElement("TOTAL")]                        public required OfxAmountType TOTAL { get; set; }
    [XmlElement("SUBACCTSEC")]                   public required OfxSubAccountEnum SUBACCTSEC { get; set; }
    [XmlElement("SUBACCTFUND")]                  public required OfxSubAccountEnum SUBACCTFUND { get; set; }
    [XmlElement("CURRENCY")]                     public OfxCurrency? CURRENCY { get; set; }
    [XmlElement("ORIGCURRENCY")]                 public OfxCurrency? ORIGCURRENCY { get; set; }
    [XmlElement("INV401KSOURCE")]                public OfxInvestment401kSourceEnum? INV401KSOURCE { get; set; }
}
