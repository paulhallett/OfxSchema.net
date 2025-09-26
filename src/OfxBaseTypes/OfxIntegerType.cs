namespace OfxSchema;

public abstract record OfxIntegerType : IXmlSerializable
{
    private int _backingField;
    
    protected OfxIntegerType() { _backingField = 0; }
    
    private static readonly IntegerTypeXmlConverter Converter = new();

    public System.Xml.Schema.XmlSchema? GetSchema() => null;

    public void ReadXml(System.Xml.XmlReader reader)
    {
        _backingField = Converter.Read(reader, typeof(int));
    }

    public void WriteXml(System.Xml.XmlWriter writer)
    {
        Converter.Write(writer, _backingField);
    }
}