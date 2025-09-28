// ReSharper disable InconsistentNaming

namespace OfxSchema;

public record OfxBankResponseMessageSetV1        //   https://schemas.liquid-technologies.com/OFX/2.1.1/bankmsgsrsv12.html
{
    [XmlElement("STMTTRNRS")]                    public required List<OfxStatementTransactionResponse> STMTTRNRS { get; set; }
}