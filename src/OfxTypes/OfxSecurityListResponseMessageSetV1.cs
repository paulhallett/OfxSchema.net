// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSecurityListResponseMessageSetV1 : OfxAbstractResponseMessageSet
{
    // <xsd:complexType name="SecurityListResponseMessageSetV1">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SECLISTMSGSRSV1" is of type "SecurityListResponseMessageSetV1"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("SECLISTTRNRS")]                 public List<OfxSecurityListTransactionResponse>? SECLISTTRNRS { get; set; }
    [XmlElement("SECLIST")]                      public OfxSecurityList? SECLIST { get; set; }
}
