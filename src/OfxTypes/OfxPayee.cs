// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxPayee
{
    // <xsd:complexType name="Payee">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "PAYEE" is of type "Payee"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="NAME" type="ofx:GenericNameType" />
    //         <xsd:sequence>
    //             <xsd:element name="ADDR1" type="ofx:AddressType" />
    //             <xsd:sequence minOccurs="0">
    //                 <xsd:element name="ADDR2" type="ofx:AddressType" />
    //                 <xsd:element name="ADDR3" type="ofx:AddressType" minOccurs="0" />
    //             </xsd:sequence>
    //         </xsd:sequence>
    //         <xsd:element name="CITY" type="ofx:AddressType" />
    //         <xsd:element name="STATE" type="ofx:StateType" />
    //         <xsd:element name="POSTALCODE" type="ofx:ZipType" />
    //         <xsd:element name="COUNTRY" type="ofx:CountryType" minOccurs="0" />
    //         <xsd:element name="PHONE" type="ofx:PhoneType" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("NAME")]                         public required OfxGenericNameType NAME { get; set; }
    [XmlElement("ADDR1")]                        public OfxAddressType? ADDR1 { get; set; }
    [XmlElement("ADDR2")]                        public OfxAddressType? ADDR2 { get; set; }
    [XmlElement("ADDR3")]                        public OfxAddressType? ADDR3 { get; set; }
    [XmlElement("CITY")]                         public required OfxAddressType CITY { get; set; }
    [XmlElement("STATE")]                        public required OfxStateType STATE { get; set; }
    [XmlElement("POSTALCODE")]                   public required OfxZipType POSTALCODE { get; set; }
    [XmlElement("COUNTRY")]                      public OfxCountryType? COUNTRY { get; set; }
    [XmlElement("PHONE")]                        public required OfxPhoneType PHONE { get; set; }
}
