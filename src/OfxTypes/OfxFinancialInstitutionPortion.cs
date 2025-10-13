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
    //     <xsd:sequence>
    //         <xsd:element name="FIASSETCLASS" type="ofx:GenericNameType" />
    //         <xsd:element name="PERCENT" type="ofx:RateType" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("FIASSETCLASS")]                 public required OfxGenericNameType FIASSETCLASS { get; set; }
    [XmlElement("PERCENT")]                      public required OfxRateType PERCENT { get; set; }
}
