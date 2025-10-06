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
    //         <xsd:choice minOccurs="0">
    //             <xsd:element name="MFINFO" type="ofx:MutualFundInfo" />
    //             <xsd:element name="STOCKINFO" type="ofx:StockInfo" />
    //             <xsd:element name="OPTINFO" type="ofx:OptionInfo" />
    //             <xsd:element name="DEBTINFO" type="ofx:DebtInfo" />
    //             <xsd:element name="OTHERINFO" type="ofx:OtherInfo" />
    //         </xsd:choice>
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("MFINFO")]                       public required OfxMutualFundInfo MFINFO { get; set; }
    [XmlElement("STOCKINFO")]                    public required OfxStockInfo STOCKINFO { get; set; }
    [XmlElement("OPTINFO")]                      public required OfxOptionInfo OPTINFO { get; set; }
    [XmlElement("DEBTINFO")]                     public required OfxDebtInfo DEBTINFO { get; set; }
    [XmlElement("OTHERINFO")]                    public required OfxOtherInfo OTHERINFO { get; set; }
}
