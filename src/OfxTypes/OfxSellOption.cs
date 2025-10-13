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
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractInvestmentSellTransaction" />
    //             <xsd:sequence>
    //                 <xsd:element name="OPTSELLTYPE" type="ofx:OptionSellEnum" />
    //                 <xsd:element name="SHPERCTRCT" type="ofx:SharesPerType" />
    //                 <xsd:element name="RELFITID" type="ofx:FinancialInstitutionTransactionIdType" minOccurs="0" />
    //                 <xsd:element name="RELTYPE" type="ofx:RelatedEnum" minOccurs="0" />
    //                 <xsd:element name="SECURED" type="ofx:SecuredEnum" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("OPTSELLTYPE")]                  public required OfxOptionSellEnum OPTSELLTYPE { get; set; }
    [XmlElement("SHPERCTRCT")]                   public required OfxSharesPerType SHPERCTRCT { get; set; }
    [XmlElement("RELFITID")]                     public OfxFinancialInstitutionTransactionIdType? RELFITID { get; set; }
    [XmlElement("RELTYPE")]                      public OfxRelatedEnum? RELTYPE { get; set; }
    [XmlElement("SECURED")]                      public OfxSecuredEnum? SECURED { get; set; }
    
    public virtual bool ShouldSerializeRELTYPE() => RELTYPE.HasValue;
    public virtual bool ShouldSerializeSECURED() => SECURED.HasValue;
}
