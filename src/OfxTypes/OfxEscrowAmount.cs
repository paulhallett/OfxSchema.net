// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxEscrowAmount
{
    // <xsd:complexType name="EscrowAmount">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element ESCRWAMT is of type "EscrowAmount"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("ESCRWTOTAL")]                   public required OfxAmountType ESCRWTOTAL { get; set; }
    [XmlElement("ESCRWTAX")]                     public OfxAmountType? ESCRWTAX { get; set; }
    [XmlElement("ESCRWINS")]                     public OfxAmountType? ESCRWINS { get; set; }
    [XmlElement("ESCRWPMI")]                     public OfxAmountType? ESCRWPMI { get; set; }
    [XmlElement("ESCRWFEES")]                    public OfxAmountType? ESCRWFEES { get; set; }
    [XmlElement("ESCRWOTHER")]                   public OfxAmountType? ESCRWOTHER { get; set; }
}
