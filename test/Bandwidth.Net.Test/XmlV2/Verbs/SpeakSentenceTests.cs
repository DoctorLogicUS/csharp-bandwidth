using System.Xml.Serialization;
using Bandwidth.Net.XmlV2.Verbs;
using Bandwidth.Net.Xml;
using Xunit;
using System;

namespace Bandwidth.Net.Test.XmlV2.Verbs
{
  public class SpeakSentenceTests
  {
    [Fact]
    public void TestConstructor()
    {
      new SpeakSentence();
    }

    [Fact]
    public void TestReadXml()
    {
      var instance = new SpeakSentence() as IXmlSerializable;
      Assert.Throws<NotImplementedException>(() => instance.ReadXml(null));
    }

    [Fact]
    public void TestGetSchema()
    {
      var instance = new SpeakSentence() as IXmlSerializable;
      Assert.Null(instance.GetSchema());
    }

    [Fact]
    public void TestWriteXml()
    {
      var response = new Response(new SpeakSentence{
        Gender = "male",
        Locale = "en_UK",
        Sentence = "Hello",
        Voice = "kate"
      });
      Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\"?>\n<Response>\n  <SpeakSentence gender=\"male\" locale=\"en_UK\" voice=\"kate\">Hello</SpeakSentence>\n</Response>", response.ToXml().Replace("\r\n", "\n"));
    }
  }
}
