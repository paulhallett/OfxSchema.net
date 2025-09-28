// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxStatementTransactionResponse    //   https://schemas.liquid-technologies.com/OFX/2.1.1/stmttrnrs1.html
{
    [XmlElement("TRNUID")]                       public required OfxGloballyUniqueUserIdType TRNUID { get; set; }
    [XmlElement("STATUS")]                       public required OfxStatus STATUS { get; set; }
    [XmlElement("CLTCOOKIE")]                    public OfxIdType? CLTCOOKIE { get; set; }
    [XmlElement("STMTRS")]                       public OfxStatementResponse? STMTRS { get; set; }    
}