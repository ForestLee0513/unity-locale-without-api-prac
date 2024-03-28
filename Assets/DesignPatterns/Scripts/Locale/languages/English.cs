using System.Collections.Generic;

public class English : Locale
{
    public string LocaleKey => "en-us";
    public Dictionary<string, string> LocaledTexts => new Dictionary<string, string>()
    {
        // lobby
        { "info", "Language: en-us\n\nPlayer Name: Test\nPlayer Level: 10" },
        { "test", "Hello" }
    };
}
