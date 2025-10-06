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
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractInvestmentTransaction" />
    //             <xsd:sequence>
    //                 <xsd:element name="SECID" type="ofx:SecurityId" />
    //                 <xsd:element name="SUBACCTSEC" type="ofx:SubAccountEnum" />
    //                 <xsd:element name="OLDUNITS" type="ofx:QuantityType" />
    //                 <xsd:element name="NEWUNITS" type="ofx:QuantityType" />
    //                 <xsd:element name="NUMERATOR" type="ofx:QuantityType" />
    //                 <xsd:element name="DENOMINATOR" type="ofx:QuantityType" />
    //                 <xsd:element name="CURRENCY" type="ofx:Currency" minOccurs="0" />
    //                 <xsd:element name="ORIGCURRENCY" type="ofx:Currency" minOccurs="0" />
    //                 <xsd:element name="FRACCASH" type="ofx:AmountType" minOccurs="0" />
    //                 <xsd:element name="SUBACCTFUND" type="ofx:SubAccountEnum" minOccurs="0" />
    //                 <xsd:element name="INV401KSOURCE" type="ofx:Investment401kSourceEnum" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
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
    
    public virtual bool ShouldSerializeSUBACCTFUND() => SUBACCTFUND.HasValue;
    public virtual bool ShouldSerializeINV401KSOURCE() => INV401KSOURCE.HasValue;
}
