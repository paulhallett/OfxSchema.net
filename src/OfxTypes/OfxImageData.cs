// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxImageData
{
    // <xsd:complexType name="ImageData">
    //     <xsd:annotation>
    //         <xsd:documentation>
    //               The OFX element "IMAGEDATA" is of type "ImageData"
    //         </xsd:documentation>
    //     </xsd:annotation>
    //     <xsd:sequence>
    //         <xsd:element name="IMAGETYPE" type="ofx:ImageTypeEnum" />
    //         <xsd:element name="IMAGEREF" type="ofx:ImageRefType" />
    //         <xsd:element name="IMAGEREFTYPE" type="ofx:ImageRefTypeEnum" />
    //         <xsd:choice>
    //             <xsd:element name="IMAGEDELAY" type="ofx:ImageDelayType" />
    //             <xsd:element name="DTIMAGEAVAIL" type="ofx:DateTimeType" />
    //         </xsd:choice>
    //         <xsd:element name="IMAGETTL" type="ofx:ImageTotalType" minOccurs="0" />
    //         <xsd:element name="CHECKSUP" type="ofx:CheckSupportEnum" minOccurs="0" />
    //     </xsd:sequence>
    // </xsd:complexType>
    
    [XmlElement("IMAGETYPE")]                    public required OfxImageTypeEnum IMAGETYPE { get; set; }
    [XmlElement("IMAGEREF")]                     public required OfxImageRefType IMAGEREF { get; set; }
    [XmlElement("IMAGEREFTYPE")]                 public required OfxImageRefTypeEnum IMAGEREFTYPE { get; set; }
    [XmlElement("IMAGEDELAY")]                   public required OfxImageDelayType IMAGEDELAY { get; set; }
    [XmlElement("DTIMAGEAVAIL")]                 public required OfxDateTimeType DTIMAGEAVAIL { get; set; }
    [XmlElement("IMAGETTL")]                     public OfxImageTotalType? IMAGETTL { get; set; }
    [XmlElement("CHECKSUP")]                     public OfxCheckSupportEnum? CHECKSUP { get; set; }
    
    public virtual bool ShouldSerializeCHECKSUP() => CHECKSUP.HasValue;
}
