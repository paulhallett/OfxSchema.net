namespace OfxSchema.net.Tests.OfxBaseTypes;

public class OfxDateTimeTypeTests
{
    [Theory]
    [InlineData("20230101")]
    public void OfxDateTimeType_Initialization_ShouldInitialize(string dateString)
    {
        var ofxDateTimeType = new OfxDateTimeType();
        ofxDateTimeType.FromString(dateString);
    }
}