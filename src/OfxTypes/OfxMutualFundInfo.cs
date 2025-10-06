// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxMutualFundInfo : OfxAbstractSecurityInfo
{
    // <xsd:complexType name="MutualFundInfo">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "MFINFO" is of type "MutualFundInfo"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractSecurityInfo" />
    //             <xsd:sequence>
    //                 <xsd:element name="MFTYPE" type="ofx:MutualFundTypeEnum" minOccurs="0" />
    //                 <xsd:element name="YIELD" type="ofx:RateType" minOccurs="0" />
    //                 <xsd:element name="DTYIELDASOF" type="ofx:DateTimeType" minOccurs="0" />
    //                 <xsd:element name="MFASSETCLASS" type="ofx:MutualFundAssetClass" minOccurs="0" />
    //                 <xsd:element name="FIMFASSETCLASS" type="ofx:FinancialInstitutionMutualFundAssetClass" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("MFTYPE")]                       public OfxMutualFundTypeEnum? MFTYPE { get; set; }
    [XmlElement("YIELD")]                        public OfxRateType? YIELD { get; set; }
    [XmlElement("DTYIELDASOF")]                  public OfxDateTimeType? DTYIELDASOF { get; set; }
    [XmlElement("MFASSETCLASS")]                 public OfxMutualFundAssetClass? MFASSETCLASS { get; set; }
    [XmlElement("FIMFASSETCLASS")]               public OfxFinancialInstitutionMutualFundAssetClass? FIMFASSETCLASS { get; set; }
    
    public virtual bool ShouldSerializeMFTYPE() => MFTYPE.HasValue;
}
