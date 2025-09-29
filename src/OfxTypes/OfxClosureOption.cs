// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxClosureOption : OfxAbstractInvestmentTransaction
{
    // <xsd:complexType name="ClosureOption">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "CLOSUREOPT" is of type "ClosureOption"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("SECID")]                        public required OfxSecurityId SECID { get; set; }
    [XmlElement("OPTACTION")]                    public required OfxOptionActionEnum OPTACTION { get; set; }
    [XmlElement("UNITS")]                        public required OfxQuantityType UNITS { get; set; }
    [XmlElement("SHPERCTRCT")]                   public required OfxSharesPerType SHPERCTRCT { get; set; }
    [XmlElement("SUBACCTSEC")]                   public required OfxSubAccountEnum SUBACCTSEC { get; set; }
    [XmlElement("RELFITID")]                     public OfxFinancialInstitutionTransactionIdType? RELFITID { get; set; }
    [XmlElement("GAIN")]                         public OfxAmountType? GAIN { get; set; }
}
