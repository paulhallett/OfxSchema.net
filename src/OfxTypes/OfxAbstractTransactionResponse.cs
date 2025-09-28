// ReSharper disable InconsistentNaming

namespace OfxSchema;

public abstract record OfxAbstractTransactionResponse : OfxAbstractResponse
{
    // <xsd:complexType name="AbstractTransactionResponse">
    // </xsd:complexType>
    
    [XmlElement("TRNUID")]                       public required OfxGloballyUniqueUserIdType TRNUID { get; set; }
    [XmlElement("STATUS")]                       public required OfxStatus STATUS { get; set; }
    [XmlElement("CLTCOOKIE")]                    public OfxIdType? CLTCOOKIE { get; set; }
}
