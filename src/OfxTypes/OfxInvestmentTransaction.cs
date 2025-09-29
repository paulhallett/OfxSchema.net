// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxInvestmentTransaction
{
    // <xsd:complexType name="InvestmentTransaction">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "INVTRAN" is of type "InvestmentTransaction"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("FITID")]                        public required OfxFinancialInstitutionTransactionIdType FITID { get; set; }
    [XmlElement("SRVRTID")]                      public OfxServerIdType? SRVRTID { get; set; }
    [XmlElement("DTTRADE")]                      public required OfxDateTimeType DTTRADE { get; set; }
    [XmlElement("DTSETTLE")]                     public OfxDateTimeType? DTSETTLE { get; set; }
    [XmlElement("REVERSALFITID")]                public OfxFinancialInstitutionTransactionIdType? REVERSALFITID { get; set; }
    [XmlElement("MEMO")]                         public OfxMessageType? MEMO { get; set; }
}
