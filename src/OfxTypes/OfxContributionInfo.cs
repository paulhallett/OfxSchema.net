// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxContributionInfo
{
    // <xsd:complexType name="ContributionInfo">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "CONTRIBINFO" is of type "ContributionInfo"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("CONTRIBSECURITY")]              public required List<OfxContributionSecurity> CONTRIBSECURITY { get; set; }
}
