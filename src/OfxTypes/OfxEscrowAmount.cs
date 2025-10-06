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
    //     <xsd:sequence>
    //         <xsd:element name="ESCRWTOTAL" type="ofx:AmountType" />
    //         <xsd:element name="ESCRWTAX" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="ESCRWINS" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="ESCRWPMI" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="ESCRWFEES" type="ofx:AmountType" minOccurs="0" />
    //         <xsd:element name="ESCRWOTHER" type="ofx:AmountType" minOccurs="0" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("ESCRWTOTAL")]                   public required OfxAmountType ESCRWTOTAL { get; set; }
    [XmlElement("ESCRWTAX")]                     public OfxAmountType? ESCRWTAX { get; set; }
    [XmlElement("ESCRWINS")]                     public OfxAmountType? ESCRWINS { get; set; }
    [XmlElement("ESCRWPMI")]                     public OfxAmountType? ESCRWPMI { get; set; }
    [XmlElement("ESCRWFEES")]                    public OfxAmountType? ESCRWFEES { get; set; }
    [XmlElement("ESCRWOTHER")]                   public OfxAmountType? ESCRWOTHER { get; set; }
}
