// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSplit : OfxAbstractInvestmentTransaction
{
    // <xsd:complexType name="Split">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SPLIT" is of type "Split"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("SECID")]                        public required OfxSecurityId SECID { get; set; }
    [XmlElement("SUBACCTSEC")]                   public required OfxSubAccountEnum SUBACCTSEC { get; set; }
    [XmlElement("OLDUNITS")]                     public required OfxQuantityType OLDUNITS { get; set; }
    [XmlElement("NEWUNITS")]                     public required OfxQuantityType NEWUNITS { get; set; }
    [XmlElement("NUMERATOR")]                    public required OfxQuantityType NUMERATOR { get; set; }
    [XmlElement("DENOMINATOR")]                  public required OfxQuantityType DENOMINATOR { get; set; }
    [XmlElement("CURRENCY")]                     public OfxCurrency? CURRENCY { get; set; }
    [XmlElement("ORIGCURRENCY")]                 public OfxCurrency? ORIGCURRENCY { get; set; }
    [XmlElement("FRACCASH")]                     public OfxAmountType? FRACCASH { get; set; }
    [XmlElement("SUBACCTFUND")]                  public OfxSubAccountEnum? SUBACCTFUND { get; set; }
    [XmlElement("INV401KSOURCE")]                public OfxInvestment401kSourceEnum? INV401KSOURCE { get; set; }
}
