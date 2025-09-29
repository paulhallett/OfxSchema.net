// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxMarginInterest : OfxAbstractInvestmentTransaction
{
    // <xsd:complexType name="MarginInterest">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "MARGININTEREST" is of type "MarginInterest"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("TOTAL")]                        public required OfxAmountType TOTAL { get; set; }
    [XmlElement("SUBACCTFUND")]                  public required OfxSubAccountEnum SUBACCTFUND { get; set; }
    [XmlElement("CURRENCY")]                     public OfxCurrency? CURRENCY { get; set; }
    [XmlElement("ORIGCURRENCY")]                 public OfxCurrency? ORIGCURRENCY { get; set; }
}
