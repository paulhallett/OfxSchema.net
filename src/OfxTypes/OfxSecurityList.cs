// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxSecurityList
{
    // <xsd:complexType name="SecurityList">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "SECLIST" is of type "SecurityList"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:choice minOccurs="0" maxOccurs="unbounded">
    //             <xsd:element name="MFINFO" type="ofx:MutualFundInfo" />
    //             <xsd:element name="STOCKINFO" type="ofx:StockInfo" />
    //             <xsd:element name="OPTINFO" type="ofx:OptionInfo" />
    //             <xsd:element name="DEBTINFO" type="ofx:DebtInfo" />
    //             <xsd:element name="OTHERINFO" type="ofx:OtherInfo" />
    //         </xsd:choice>
    //     </xsd:sequence>
    // </xsd:complexType>
    
    
    [XmlElement("MFINFO", typeof(OfxMutualFundInfo))]
    [XmlElement("STOCKINFO", typeof(OfxStockInfo))]
    [XmlElement("OPTINFO", typeof(OfxOptionInfo))]
    [XmlElement("DEBTINFO", typeof(OfxDebtInfo))]
    [XmlElement("OTHERINFO", typeof(OfxOtherInfo))]
    public required List<OfxAbstractSecurityInfo> ITEMS { get; set; }
    
}
