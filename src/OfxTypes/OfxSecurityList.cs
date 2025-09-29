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
    // </xsd:complexType>
    
    [XmlElement("MFINFO")]                       public required OfxMutualFundInfo MFINFO { get; set; }
    [XmlElement("STOCKINFO")]                    public required OfxStockInfo STOCKINFO { get; set; }
    [XmlElement("OPTINFO")]                      public required OfxOptionInfo OPTINFO { get; set; }
    [XmlElement("DEBTINFO")]                     public required OfxDebtInfo DEBTINFO { get; set; }
    [XmlElement("OTHERINFO")]                    public required OfxOtherInfo OTHERINFO { get; set; }
}
