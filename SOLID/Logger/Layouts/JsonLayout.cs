using System.Text;

namespace Logger.Layouts
{
    class JsonLayout : ILayout
    {
        public string Template => @"""log"":{{
  ""date"": ""{0}"",
  ""level"": ""{1}"",
  ""message"": ""{2}""
}},";

    }
}
