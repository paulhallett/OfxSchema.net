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
    // </xsd:complexType>
    
    [XmlElement("NAME")]                         public required OfxGenericNameType NAME { get; set; }
    [XmlElement("ADDR1")]                        public required OfxAddressType ADDR1 { get; set; }
    [XmlElement("ADDR2")]                        public required OfxAddressType ADDR2 { get; set; }
    [XmlElement("ADDR3")]                        public OfxAddressType? ADDR3 { get; set; }
    [XmlElement("CITY")]                         public required OfxAddressType CITY { get; set; }
    [XmlElement("STATE")]                        public required OfxStateType STATE { get; set; }
    [XmlElement("POSTALCODE")]                   public required OfxZipType POSTALCODE { get; set; }
    [XmlElement("COUNTRY")]                      public OfxCountryType? COUNTRY { get; set; }
    [XmlElement("PHONE")]                        public required OfxPhoneType PHONE { get; set; }
}
