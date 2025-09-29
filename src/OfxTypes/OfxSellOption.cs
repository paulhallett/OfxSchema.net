// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSellOption : OfxAbstractInvestmentSellTransaction
{
    // <xsd:complexType name="SellOption">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SELLOPT" is of type "SellOption"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("OPTSELLTYPE")]                  public required OfxOptionSellEnum OPTSELLTYPE { get; set; }
    [XmlElement("SHPERCTRCT")]                   public required OfxSharesPerType SHPERCTRCT { get; set; }
    [XmlElement("RELFITID")]                     public OfxFinancialInstitutionTransactionIdType? RELFITID { get; set; }
    [XmlElement("RELTYPE")]                      public OfxRelatedEnum? RELTYPE { get; set; }
    [XmlElement("SECURED")]                      public OfxSecuredEnum? SECURED { get; set; }
}
