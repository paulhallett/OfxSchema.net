// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxBankIdType : OfxStringType
{
    // <xsd:simpleType name="BankIdType">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "BANKID" is of type "BankIdType"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:maxLength value="9" />
    //         <xsd:minLength value="1" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    public static implicit operator OfxBankIdType(string value) => new(value);
    public static implicit operator string(OfxBankIdType value) => value._backingField;
    
    public OfxBankIdType() { }
    private OfxBankIdType(string value)
    {
        _backingField = value;
    }
    
    public override string ToString() => _backingField;
}
