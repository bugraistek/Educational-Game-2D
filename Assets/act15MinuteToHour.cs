using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class act15MinuteToHour : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Dropdown dropdown;
    public TMP_Text outputText;
    public Button convertButton;


    public void ConvertTime()
    {
        string input = inputField.text;
        float timeValue;

        if (float.TryParse(input, out timeValue))
        {
            switch (dropdown.value)
            {
                case 0: // Saniyeden dakikaya
                    outputText.text = MinutesToHours(timeValue).ToString("F2") + " saat";
                    break;
                case 1: // Dakikadan saniyeye
                    outputText.text = HoursToMinutes(timeValue).ToString("F2") + " dakika";
                    break;
                default:
                    outputText.text = "Geçersiz dönüşüm!";
                    break;
            }
        }
        else
        {
            outputText.text = "Geçersiz giriş!";
        }
    }

    float MinutesToHours(float minutes) => minutes / 60f;
    float HoursToMinutes(float hours) => hours * 60f;
}
