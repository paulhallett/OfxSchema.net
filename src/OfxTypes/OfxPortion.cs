// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxPortion
{
    // <xsd:complexType name="Portion">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "PORTION" is of type "Portion"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("ASSETCLASS")]                   public required OfxAssetClassEnum ASSETCLASS { get; set; }
    [XmlElement("PERCENT")]                      public required OfxRateType PERCENT { get; set; }
}
