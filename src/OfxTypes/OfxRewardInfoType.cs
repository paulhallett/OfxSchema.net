// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxRewardInfoType
{
    // <xsd:complexType name="RewardInfoType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "REWARDINFO" is of type "RewardInfoType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("NAME")]                         public required OfxGenericNameType NAME { get; set; }
    [XmlElement("REWARDBAL")]                    public required OfxAmountType REWARDBAL { get; set; }
    [XmlElement("REWARDEARNED")]                 public OfxAmountType? REWARDEARNED { get; set; }
}
