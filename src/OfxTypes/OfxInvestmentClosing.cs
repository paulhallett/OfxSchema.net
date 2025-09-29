// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentClosing
{
    // <xsd:complexType name="InvestmentClosing">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVCLOSING" is of type "InvestmentClosing"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("FITID")]                        public required OfxFinancialInstitutionTransactionIdType FITID { get; set; }
    [XmlElement("IMAGEDATA")]                    public OfxImageData? IMAGEDATA { get; set; }
}
