namespace OfxSchema;

public abstract record OfxStringType : IXmlSerializable
{
    protected string _backingField;
    
    protected OfxStringType() { _backingField = string.Empty; }
    protected OfxStringType(string value) { _backingField = value; }
    
    public override string ToString() => _backingField;

    private static readonly StringTypeXmlConverter Converter = new();

    public System.Xml.Schema.XmlSchema? GetSchema() => null;

    public void ReadXml(System.Xml.XmlReader reader)
    {
        _backingField = Converter.Read(reader, typeof(string)) ?? string.Empty;
    }

    public void WriteXml(System.Xml.XmlWriter writer)
    {
        Converter.Write(writer, _backingField);
    }
}