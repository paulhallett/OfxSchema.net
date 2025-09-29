// ReSharper disable InconsistentNaming

namespace OfxSchema;

public abstract record OfxAbstractSyncResponse : OfxAbstractResponse
{
    // <xsd:complexType name="AbstractSyncResponse">
    // </xsd:complexType>
    
    [XmlElement("TOKEN")]                        public required OfxServerIdType TOKEN { get; set; }
    [XmlElement("LOSTSYNC")]                     public OfxBooleanType? LOSTSYNC { get; set; }
}
