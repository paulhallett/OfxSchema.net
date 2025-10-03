// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxBankTransactionList
{
    // <xsd:complexType name="BankTransactionList">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "BANKTRANLIST" is of type "BankTransactionList"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("DTSTART")]                      public required OfxDateTimeType DTSTART { get; set; }
    [XmlElement("DTEND")]                        public required OfxDateTimeType DTEND { get; set; }
    [XmlElement("STMTTRN")]                      public List<OfxStatementTransaction>? STMTTRN { get; set; }
}
