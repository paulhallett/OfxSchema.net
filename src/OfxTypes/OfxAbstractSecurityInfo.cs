// ReSharper disable InconsistentNaming

namespace OfxSchema;

public abstract record OfxAbstractSecurityInfo
{
    // <xsd:complexType name="AbstractSecurityInfo">
    // </xsd:complexType>
    
    [XmlElement("SECINFO")]                      public required OfxGeneralSecurityInfo SECINFO { get; set; }
}
