// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxFinancialInstitutionTransactionIdType : OfxStringType
{
    // <xsd:simpleType name="FinancialInstitutionTransactionIdType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "FITID" is of type "FinancialInstitutionTransactionIdType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="255" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxFinancialInstitutionTransactionIdType(string value) => new(value);
    public static implicit operator string(OfxFinancialInstitutionTransactionIdType value) => value._backingField;
    
    public OfxFinancialInstitutionTransactionIdType() { }
    private OfxFinancialInstitutionTransactionIdType(string value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField;
}
