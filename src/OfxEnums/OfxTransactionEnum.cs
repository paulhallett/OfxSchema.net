// ReSharper disable InconsistentNaming

namespace OfxSchema;

public enum OfxTransactionEnum
{
    // <xsd:simpleType name="TransactionEnum">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "TRANSACTIONENUM" is of type "TransactionEnum"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:restriction base="xsd:string">
    //         <xsd:whiteSpace value="collapse" />
    //         <xsd:enumeration value="CREDIT" />
    //         <xsd:enumeration value="DEBIT" />
    //         <xsd:enumeration value="INT" />
    //         <xsd:enumeration value="DIV" />
    //         <xsd:enumeration value="FEE" />
    //         <xsd:enumeration value="SRVCHG" />
    //         <xsd:enumeration value="DEP" />
    //         <xsd:enumeration value="ATM" />
    //         <xsd:enumeration value="POS" />
    //         <xsd:enumeration value="XFER" />
    //         <xsd:enumeration value="CHECK" />
    //         <xsd:enumeration value="PAYMENT" />
    //         <xsd:enumeration value="CASH" />
    //         <xsd:enumeration value="DIRECTDEP" />
    //         <xsd:enumeration value="DIRECTDEBIT" />
    //         <xsd:enumeration value="REPEATPMT" />
    //         <xsd:enumeration value="HOLD" />
    //         <xsd:enumeration value="OTHER" />
    //     </xsd:restriction>
    // </xsd:simpleType>    
    
    CREDIT,
    DEBIT,
    INT,
    DIV,
    FEE,
    SRVCHG,
    DEP,
    ATM,
    POS,
    XFER,
    CHECK,
    PAYMENT,
    CASH,
    DIRECTDEP,
    DIRECTDEBIT,
    REPEATPMT,
    HOLD,
    OTHER,
}
