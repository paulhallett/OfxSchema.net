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
    // </xsd:complexType>
    
    [XmlElement("BAL")]                          public List<OfxBalance>? BAL { get; set; }
}
