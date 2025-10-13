namespace OfxSchema;

public abstract class XmlConverter<T>
{
    public abstract T? Read(System.Xml.XmlReader reader, Type typeToConvert);
    public abstract void Write(System.Xml.XmlWriter writer, T value);
}

public class StringTypeXmlConverter : XmlConverter<string>
{
    public override string? Read(System.Xml.XmlReader reader, Type typeToConvert)
    {
        if (reader.IsEmptyElement)
        {
            reader.ReadStartElement();
            return null;
        }
        
        reader.ReadStartElement();
        var value = reader.ReadContentAsString();
        reader.ReadEndElement();
        
        return string.IsNullOrEmpty(value) ? null : value;
    }

    public override void Write(System.Xml.XmlWriter writer, string value)
    {
        writer.WriteString(value);
    }
}
public class IntegerTypeXmlConverter : XmlConverter<int>
{
    public override int Read(System.Xml.XmlReader reader, Type typeToConvert)
    {
        if (reader.IsEmptyElement)
        {
            reader.ReadStartElement();
            return 0;
        }
        
        reader.ReadStartElement();
        var value = reader.ReadContentAsInt();
        reader.ReadEndElement();
        
        return value;
    }

    public override void Write(System.Xml.XmlWriter writer, int value)
    {
        writer.WriteValue(value);
    }
}
public class DecimalTypeXmlConverter : XmlConverter<decimal>
{
    public override decimal Read(System.Xml.XmlReader reader, Type typeToConvert)
    {
        if (reader.IsEmptyElement)
        {
            reader.ReadStartElement();
            return 0;
        }
        
        reader.ReadStartElement();
        var value = reader.ReadContentAsDecimal();
        reader.ReadEndElement();
        
        return value;
    }

    public override void Write(System.Xml.XmlWriter writer, decimal value)
    {
        writer.WriteValue(value);
    }
}