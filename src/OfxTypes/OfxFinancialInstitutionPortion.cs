// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxFinancialInstitutionPortion
{
    // <xsd:complexType name="FinancialInstitutionPortion">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "FIPORTION" is of type "FinancialInstitutionPortion"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("FIASSETCLASS")]                 public required OfxGenericNameType FIASSETCLASS { get; set; }
    [XmlElement("PERCENT")]                      public required OfxRateType PERCENT { get; set; }
}
