using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class act18MonthsToYear : MonoBehaviour
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
                    outputText.text = MonthToYear(timeValue).ToString("F2") + " yıl";
                    break;
                case 1: // Dakikadan saniyeye
                    outputText.text = YearToMonth(timeValue).ToString("F2") + " ay";
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

    float MonthToYear(float minutes) => minutes / 12f;
    float YearToMonth(float hours) => hours * 12f;
}
