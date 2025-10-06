namespace OfxSchema;

public record OfxDateTimeType : IXmlSerializable
{
    private DateTime _backingField;
    private string _format = BASIC_FORMAT;
    
    public static implicit operator OfxDateTimeType(DateTime value) => new(value);
    public static implicit operator DateTime(OfxDateTimeType value) => value._backingField;
    public static implicit operator OfxDateTimeType(DateOnly value) => new(value);

    public OfxDateTimeType() { }

    private OfxDateTimeType(DateTime value)
    {
        _backingField = value;
        _format = TIMESTAMP_FORMAT;
        if (value is { Hour: 0, Minute: 0, Second: 0 }) _format = BASIC_FORMAT;
    }

    private OfxDateTimeType(DateOnly value)
    {
        _backingField = value.ToDateTime(TimeOnly.MinValue);
        _format = BASIC_FORMAT;
    }

    public override string ToString() => _backingField.ToString(_format);
    
    private static readonly StringTypeXmlConverter Converter = new();

    public System.Xml.Schema.XmlSchema? GetSchema() => null;

    public void ReadXml(System.Xml.XmlReader reader)
    {
        var value = Converter.Read(reader, typeof(string)) ?? throw new Exception("Invalid string value");
        FromString(value);
    }

    public void FromString(string value)
    {
        string[] formats = [ BASIC_FORMAT, TIMESTAMP_FORMAT];
        
        foreach (var format in formats)
        {
            if (!DateTime.TryParseExact(value, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result)) continue;
            
            _backingField = result;
            _format = format;
            return;
        }
        
        throw new FormatException($"Unable to parse date value: {value}");
    }

    public void WriteXml(System.Xml.XmlWriter writer)
    {
        Converter.Write(writer, ToString());
    }

    private const string BASIC_FORMAT = "yyyyMMdd";
    private const string TIMESTAMP_FORMAT = "yyyyMMddhhmmss";
    
    //TODO: Parsers for the below other allowed format strings
    private const string OTHER_FORMAT1 = "YYYYMMDDhhmmss.SSS";
    private const string OTHER_FORMAT2 = "YYYYMMDDhhmmss.SSS[+hh:mm]";
    private const string OTHER_FORMAT3 = "YYYYMMDDhhmmss.SSS[UTC]";
}