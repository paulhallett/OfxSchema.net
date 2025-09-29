// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxFinancialInstitutionMutualFundAssetClass
{
    // <xsd:complexType name="FinancialInstitutionMutualFundAssetClass">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "FIMFASSETCLASS" is of type "FinancialInstitutionMutualFundAssetClass"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("FIPORTION")]                    public required OfxFinancialInstitutionPortion FIPORTION { get; set; }
}
