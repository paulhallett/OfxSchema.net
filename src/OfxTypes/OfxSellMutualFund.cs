// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSellMutualFund : OfxAbstractInvestmentSellTransaction
{
    // <xsd:complexType name="SellMutualFund">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SELLMF" is of type "SellMutualFund"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractInvestmentSellTransaction" />
    //             <xsd:sequence>
    //                 <xsd:element name="SELLTYPE" type="ofx:SellTypeEnum" />
    //                 <xsd:element name="AVGCOSTBASIS" type="ofx:AmountType" minOccurs="0" />
    //                 <xsd:element name="RELFITID" type="ofx:FinancialInstitutionTransactionIdType" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("SELLTYPE")]                     public required OfxSellTypeEnum SELLTYPE { get; set; }
    [XmlElement("AVGCOSTBASIS")]                 public OfxAmountType? AVGCOSTBASIS { get; set; }
    [XmlElement("RELFITID")]                     public OfxFinancialInstitutionTransactionIdType? RELFITID { get; set; }
}
