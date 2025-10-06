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
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractInvestmentTransaction" />
    //             <xsd:sequence>
    //                 <xsd:element name="TOTAL" type="ofx:AmountType" />
    //                 <xsd:element name="SUBACCTFUND" type="ofx:SubAccountEnum" />
    //                 <xsd:element name="CURRENCY" type="ofx:Currency" minOccurs="0" />
    //                 <xsd:element name="ORIGCURRENCY" type="ofx:Currency" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("TOTAL")]                        public required OfxAmountType TOTAL { get; set; }
    [XmlElement("SUBACCTFUND")]                  public required OfxSubAccountEnum SUBACCTFUND { get; set; }
    [XmlElement("CURRENCY")]                     public OfxCurrency? CURRENCY { get; set; }
    [XmlElement("ORIGCURRENCY")]                 public OfxCurrency? ORIGCURRENCY { get; set; }
}
