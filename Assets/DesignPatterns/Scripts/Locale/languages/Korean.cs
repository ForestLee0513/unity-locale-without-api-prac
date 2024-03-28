using System.Collections.Generic;

public class Korean : Locale
{
    public string LocaleKey => "ko-kr";
    public Dictionary<string, string> LocaledTexts => new Dictionary<string, string>()
    {
        // lobby
        { "info", "언어: ko-kr\n\n플레이어 이름: 테스트\n플레이어 레벨: 10" },
        { "test", "안녕하세요" }
    };
}
