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
    //     <xsd:sequence>
    //         <xsd:element name="FIPORTION" type="ofx:FinancialInstitutionPortion" maxOccurs="unbounded" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("FIPORTION")]                    public required List<OfxFinancialInstitutionPortion> FIPORTION { get; set; }
}
