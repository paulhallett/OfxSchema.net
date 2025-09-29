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
    // </xsd:complexType>
    
    [XmlElement("MFTYPE")]                       public OfxMutualFundTypeEnum? MFTYPE { get; set; }
    [XmlElement("YIELD")]                        public OfxRateType? YIELD { get; set; }
    [XmlElement("DTYIELDASOF")]                  public OfxDateTimeType? DTYIELDASOF { get; set; }
    [XmlElement("MFASSETCLASS")]                 public OfxMutualFundAssetClass? MFASSETCLASS { get; set; }
    [XmlElement("FIMFASSETCLASS")]               public OfxFinancialInstitutionMutualFundAssetClass? FIMFASSETCLASS { get; set; }
    
    public virtual bool ShouldSerializeMFTYPE() => MFTYPE.HasValue;
}
