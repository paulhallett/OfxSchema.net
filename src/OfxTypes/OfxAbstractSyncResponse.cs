// ReSharper disable InconsistentNaming

namespace OfxSchema;

public abstract record OfxAbstractSyncResponse : OfxAbstractResponse
{
    // <xsd:complexType name="AbstractSyncResponse">
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractResponse" />
    //             <xsd:sequence>
    //                 <xsd:element name="TOKEN" type="ofx:ServerIdType" />
    //                 <xsd:element name="LOSTSYNC" type="ofx:BooleanType" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("TOKEN")]                        public required OfxServerIdType TOKEN { get; set; }
    [XmlElement("LOSTSYNC")]                     public OfxBooleanType? LOSTSYNC { get; set; }
    
    public virtual bool ShouldSerializeLOSTSYNC() => LOSTSYNC.HasValue;
}
