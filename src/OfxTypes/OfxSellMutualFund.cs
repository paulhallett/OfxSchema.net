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
    // </xsd:complexType>
    
    [XmlElement("SELLTYPE")]                     public required OfxSellTypeEnum SELLTYPE { get; set; }
    [XmlElement("AVGCOSTBASIS")]                 public OfxAmountType? AVGCOSTBASIS { get; set; }
    [XmlElement("RELFITID")]                     public OfxFinancialInstitutionTransactionIdType? RELFITID { get; set; }
}
