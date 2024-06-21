using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class act14SecondToMinute : MonoBehaviour
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
                    outputText.text = SecondsToMinutes(timeValue).ToString("F2") + " dakika";
                    break;
                case 1: // Dakikadan saniyeye
                    outputText.text = MinutesToSeconds(timeValue).ToString("F2") + " saniye";
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

    float SecondsToMinutes(float seconds) => seconds / 60f;
    float MinutesToSeconds(float minutes) => minutes * 60f;
}
