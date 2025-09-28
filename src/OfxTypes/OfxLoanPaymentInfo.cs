// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxLoanPaymentInfo
{
    // <xsd:complexType name="LoanPaymentInfo">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element LOANPMTINFO is of type "LoanPaymentInfo"
    //         </xsd:documentation>
    //     </xsd:annotation>
    // </xsd:complexType>
    
    [XmlElement("PRINAMT")]                      public required OfxAmountType PRINAMT { get; set; }
    [XmlElement("INTAMT")]                       public required OfxAmountType INTAMT { get; set; }
    [XmlElement("ESCRWAMT")]                     public OfxEscrowAmount? ESCRWAMT { get; set; }
    [XmlElement("INSURANCE")]                    public OfxAmountType? INSURANCE { get; set; }
    [XmlElement("LATEFEEAMT")]                   public OfxAmountType? LATEFEEAMT { get; set; }
    [XmlElement("OTHERAMT")]                     public OfxAmountType? OTHERAMT { get; set; }
}
