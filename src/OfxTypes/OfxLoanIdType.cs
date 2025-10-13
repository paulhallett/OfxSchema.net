// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxLoanIdType : OfxStringType
{
    // <xsd:simpleType name="LoanIdType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "LOANID" is of type "LoanIdType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:maxLength value="32" />
    //         <xsd:minLength value="1" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxLoanIdType(string value) => new(value);
    public static implicit operator string(OfxLoanIdType value) => value._backingField;
    
    public OfxLoanIdType() { }
    private OfxLoanIdType(string value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField;
}
