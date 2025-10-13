// ReSharper disable InconsistentNaming

namespace OfxSchema;

public abstract record OfxAbstractSecurityInfo
{
    // <xsd:complexType name="AbstractSecurityInfo">
    //     <xsd:sequence>
    //         <xsd:element name="SECINFO" type="ofx:GeneralSecurityInfo" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("SECINFO")]                      public required OfxGeneralSecurityInfo SECINFO { get; set; }
}
