// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxFinancialInstitutionIdType : OfxStringType
{
    // <xsd:simpleType name="FinancialInstitutionIdType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "FIID" is of type "FinancialInstitutionIdType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:minLength value="1" />
    //         <xsd:maxLength value="32" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxFinancialInstitutionIdType(string value) => new(value);
    public static implicit operator string(OfxFinancialInstitutionIdType value) => value._backingField;
    
    public OfxFinancialInstitutionIdType() { }
    private OfxFinancialInstitutionIdType(string value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField;
}
