using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class act16MinuteToHour : MonoBehaviour
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
                    outputText.text = HourToDays(timeValue).ToString("F2") + " gün";
                    break;
                case 1: // Dakikadan saniyeye
                    outputText.text = DaysToHour(timeValue).ToString("F2") + " saat";
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

    float HourToDays(float minutes) => minutes / 24f;
    float DaysToHour(float hours) => hours * 24f;
}
