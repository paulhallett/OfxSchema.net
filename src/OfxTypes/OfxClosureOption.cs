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
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractInvestmentTransaction" />
    //             <xsd:sequence>
    //                 <xsd:element name="SECID" type="ofx:SecurityId" />
    //                 <xsd:element name="OPTACTION" type="ofx:OptionActionEnum" />
    //                 <xsd:element name="UNITS" type="ofx:QuantityType" />
    //                 <xsd:element name="SHPERCTRCT" type="ofx:SharesPerType" />
    //                 <xsd:element name="SUBACCTSEC" type="ofx:SubAccountEnum" />
    //                 <xsd:element name="RELFITID" type="ofx:FinancialInstitutionTransactionIdType" minOccurs="0" />
    //                 <xsd:element name="GAIN" type="ofx:AmountType" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("SECID")]                        public required OfxSecurityId SECID { get; set; }
    [XmlElement("OPTACTION")]                    public required OfxOptionActionEnum OPTACTION { get; set; }
    [XmlElement("UNITS")]                        public required OfxQuantityType UNITS { get; set; }
    [XmlElement("SHPERCTRCT")]                   public required OfxSharesPerType SHPERCTRCT { get; set; }
    [XmlElement("SUBACCTSEC")]                   public required OfxSubAccountEnum SUBACCTSEC { get; set; }
    [XmlElement("RELFITID")]                     public OfxFinancialInstitutionTransactionIdType? RELFITID { get; set; }
    [XmlElement("GAIN")]                         public OfxAmountType? GAIN { get; set; }
}
