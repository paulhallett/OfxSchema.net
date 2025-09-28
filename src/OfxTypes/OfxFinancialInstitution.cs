// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxFinancialInstitution
{
    // <xsd:complexType name="FinancialInstitution">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "FI" is of type "FinancialInstitution"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("ORG")]                          public required OfxGenericNameType ORG { get; set; }
    [XmlElement("FID")]                          public OfxFinancialInstitutionIdType? FID { get; set; }
}
