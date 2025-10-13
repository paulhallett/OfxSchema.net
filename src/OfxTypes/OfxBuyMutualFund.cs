// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxBuyMutualFund : OfxAbstractInvestmentBuyTransaction
{
    // <xsd:complexType name="BuyMutualFund">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "BUYMF" is of type "BuyMutualFund"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractInvestmentBuyTransaction" />
    //             <xsd:sequence>
    //                 <xsd:element name="BUYTYPE" type="ofx:BuyEnum" />
    //                 <xsd:element name="RELFITID" type="ofx:FinancialInstitutionTransactionIdType" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("BUYTYPE")]                      public required OfxBuyEnum BUYTYPE { get; set; }
    [XmlElement("RELFITID")]                     public OfxFinancialInstitutionTransactionIdType? RELFITID { get; set; }
}
