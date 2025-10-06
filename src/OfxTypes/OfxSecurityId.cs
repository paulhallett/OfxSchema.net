// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSecurityId
{
    // <xsd:complexType name="SecurityId">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SECID" is of type "SecurityId"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="UNIQUEID" type="ofx:CusipType" />
    //         <xsd:element name="UNIQUEIDTYPE" type="ofx:SecurityUserIdType" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("UNIQUEID")]                     public required OfxCusipType UNIQUEID { get; set; }
    [XmlElement("UNIQUEIDTYPE")]                 public required OfxSecurityUserIdType UNIQUEIDTYPE { get; set; }
}
