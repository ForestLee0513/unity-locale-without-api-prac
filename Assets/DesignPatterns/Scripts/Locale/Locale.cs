using System.Collections.Generic;

public interface Locale
{
    public enum LocaleKeyTypes
    {
        KO_KR,
        EN_US
    }

    public string LocaleKey { get; }
    public Dictionary<string, string> LocaledTexts { get; }
}
