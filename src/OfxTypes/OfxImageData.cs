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
    // </xsd:complexType>
    
    [XmlElement("IMAGETYPE")]                    public required OfxImageTypeEnum IMAGETYPE { get; set; }
    [XmlElement("IMAGEREF")]                     public required OfxImageRefType IMAGEREF { get; set; }
    [XmlElement("IMAGEREFTYPE")]                 public required OfxImageRefTypeEnum IMAGEREFTYPE { get; set; }
    [XmlElement("IMAGEDELAY")]                   public required OfxImageDelayType IMAGEDELAY { get; set; }
    [XmlElement("DTIMAGEAVAIL")]                 public required OfxDateTimeType DTIMAGEAVAIL { get; set; }
    [XmlElement("IMAGETTL")]                     public OfxImageTotalType? IMAGETTL { get; set; }
    [XmlElement("CHECKSUP")]                     public OfxCheckSupportEnum? CHECKSUP { get; set; }
}
