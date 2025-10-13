// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxBalanceList
{
    // <xsd:complexType name="BalanceList">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "BALLIST" is of type "BalanceList"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="BAL" type="ofx:Balance" minOccurs="0" maxOccurs="unbounded" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("BAL")]                          public List<OfxBalance>? BAL { get; set; }
}
