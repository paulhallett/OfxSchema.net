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
    //     <xsd:sequence>
    //         <xsd:element name="NAME" type="ofx:GenericNameType" />
    //         <xsd:element name="REWARDBAL" type="ofx:AmountType" />
    //         <xsd:element name="REWARDEARNED" type="ofx:AmountType" minOccurs="0" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("NAME")]                         public required OfxGenericNameType NAME { get; set; }
    [XmlElement("REWARDBAL")]                    public required OfxAmountType REWARDBAL { get; set; }
    [XmlElement("REWARDEARNED")]                 public OfxAmountType? REWARDEARNED { get; set; }
}
