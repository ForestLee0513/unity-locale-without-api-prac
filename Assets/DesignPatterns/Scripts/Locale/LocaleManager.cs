using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static Locale;

public class LocaleManager : MonoBehaviour
{
    private Locale locale;
    private LocaleText[] targetTexts;
    private LocaleKeyTypes key;
    public Dropdown localeListDropdown;
    private void Start()
    {
        targetTexts = FindObjectsOfType<LocaleText>();
        if(localeListDropdown != null)
        {
            ApplyLocalesToDropdown();
            localeListDropdown.onValueChanged.AddListener(UpdateDropdown);
        }
        else
        {
            SetLocale(LocaleKeyTypes.KO_KR);
        }
    }
    public void UpdateDropdown(int idx)
    {
        localeListDropdown.value = idx;
        localeListDropdown.RefreshShownValue();
        SetLocale((LocaleKeyTypes)idx);
    }

    public void LoadLocale()
    {
        switch(key)
        {
            case LocaleKeyTypes.KO_KR:
                locale = new Korean();
                break;
            case LocaleKeyTypes.EN_US:
                locale = new English();
                break;
        }
    }

    public void ApplyLocalesToDropdown()
    {
        localeListDropdown.ClearOptions();
        foreach (var localeKeyValue in typeof(LocaleKeyTypes).GetEnumValues())
        {
            Dropdown.OptionData newLocaleOptionData = new Dropdown.OptionData();
            newLocaleOptionData.text = localeKeyValue.ToString();
            localeListDropdown.options.Add(newLocaleOptionData);
        };

        UpdateDropdown(0);
    }

    public void SetLocale(LocaleKeyTypes type)
    {
        key = type;
        LoadLocale();
        UpdateText();
    }

    public void UpdateText()
    {
        foreach (LocaleText targetText in targetTexts)
        {
            LocaleText targetComponent = targetText.GetComponent<LocaleText>();
            Text targetTextComponent = targetText.GetComponent<Text>();
            TextMeshProUGUI targetTMPComponent = targetText.GetComponent<TextMeshProUGUI>();

            if(targetTextComponent != null)
            {
                targetTextComponent.text = locale.LocaledTexts[targetComponent.targetKey];
            }

            if(targetTMPComponent != null)
            {
                targetTMPComponent.text = locale.LocaledTexts[targetComponent.targetKey];
            }
        }
    }

}
