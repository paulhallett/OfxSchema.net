// ReSharper disable InconsistentNaming

namespace OfxSchema;

public abstract record OfxAbstractTransactionResponse : OfxAbstractResponse
{
    // <xsd:complexType name="AbstractTransactionResponse">
    //     <xsd:complexContent>
    //         <xsd:extension base="ofx:AbstractResponse" />
    //             <xsd:sequence>
    //                 <xsd:element name="TRNUID" type="ofx:GloballyUniqueUserIdType" />
    //                 <xsd:element name="STATUS" type="ofx:Status" />
    //                 <xsd:element name="CLTCOOKIE" type="ofx:IdType" minOccurs="0" />
    //             </xsd:sequence>
    //     </xsd:complexContent>
    // </xsd:complexType>
    
    [XmlElement("TRNUID")]                       public required OfxGloballyUniqueUserIdType TRNUID { get; set; }
    [XmlElement("STATUS")]                       public required OfxStatus STATUS { get; set; }
    [XmlElement("CLTCOOKIE")]                    public OfxIdType? CLTCOOKIE { get; set; }
}
