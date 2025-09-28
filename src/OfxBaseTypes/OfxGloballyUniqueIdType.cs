namespace OfxSchema;

public abstract record OfxGloballyUniqueIdType : IXmlSerializable
{
    protected Guid _backingField;
    
    protected OfxGloballyUniqueIdType() { }
    
    private static readonly StringTypeXmlConverter Converter = new();

    public System.Xml.Schema.XmlSchema? GetSchema() => null;

    public void ReadXml(System.Xml.XmlReader reader)
    {
        var value = Converter.Read(reader, typeof(string)) ?? throw new Exception("Invalid string value");
        _backingField = Guid.Parse(value);
    }

    public void WriteXml(System.Xml.XmlWriter writer)
    {
        Converter.Write(writer, _backingField.ToString());
    }
}