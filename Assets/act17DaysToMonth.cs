using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class act17DaysToMonth : MonoBehaviour
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
                    outputText.text = DayToMonth(timeValue).ToString("F2") + " ay";
                    break;
                case 1: // Dakikadan saniyeye
                    outputText.text = MonthToDay(timeValue).ToString("F2") + " gün";
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

    float DayToMonth(float minutes) => minutes / 30f;
    float MonthToDay(float hours) => hours * 30f;
}
