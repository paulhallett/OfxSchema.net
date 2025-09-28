namespace OfxSchema;

public abstract record OfxDecimalType : IXmlSerializable
{
    protected decimal _backingField;
    
    protected OfxDecimalType() { _backingField = 0.0m; }
    
    private static readonly DecimalTypeXmlConverter Converter = new();

    public System.Xml.Schema.XmlSchema? GetSchema() => null;

    public void ReadXml(System.Xml.XmlReader reader)
    {
        _backingField = Converter.Read(reader, typeof(decimal));
    }

    public void WriteXml(System.Xml.XmlWriter writer)
    {
        Converter.Write(writer, _backingField);
    }
}