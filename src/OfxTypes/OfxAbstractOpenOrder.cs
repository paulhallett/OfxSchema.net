// ReSharper disable InconsistentNaming

namespace OfxSchema;

public abstract record OfxAbstractOpenOrder
{
    // <xsd:complexType name="AbstractOpenOrder">
    //     <xsd:sequence>
    //         <xsd:element name="OO" type="ofx:GeneralOpenOrder" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("OO")]                           public required OfxGeneralOpenOrder OO { get; set; }
}
