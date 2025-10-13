// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxMutualFundAssetClass
{
    // <xsd:complexType name="MutualFundAssetClass">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "MFASSETCLASS" is of type "MutualFundAssetClass"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="PORTION" type="ofx:Portion" maxOccurs="unbounded" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("PORTION")]                      public required List<OfxPortion> PORTION { get; set; }
}
