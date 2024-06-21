using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshPro namespace'ini ekleyin

public class act4Validator : MonoBehaviour
{
    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
    public TMP_InputField inputField3;
    public GameObject feedbackPanel;  // Geri bildirim için panel
    public TextMeshProUGUI feedbackText; // TextMeshProUGUI text component
    public Button tryAgainButton;     // Tekrar deneme butonu
    public Button NextButton;

    void Start()
    {
        feedbackPanel.SetActive(false);  // Baþlangýçta paneli gizle
    }

    public void CheckInputs()
    {
        bool isInput1Correct = inputField1.text == "0,3";
        bool isInput2Correct = inputField2.text == "200";
        bool isInput3Correct = inputField3.text == "0,4";

        if (isInput1Correct && isInput2Correct && isInput3Correct)
        {
            feedbackText.text = "Tebrikler!";
            tryAgainButton.gameObject.SetActive(false);
            NextButton.gameObject.SetActive(true);
        }
        else
        {
            feedbackText.text = "Sanýrým hata yaptýk..";
            if (!isInput1Correct) feedbackText.text += " Nar suyu L cinsinden hatalý, miktarýný kontrol et";
            if (!isInput2Correct) feedbackText.text += " Greyfurt suyu mL cinsinden hatalý, miktarýný kontrol et";
            if (!isInput3Correct) feedbackText.text += " Üzüm suyu L cinsinden hatalý, miktarýný kontrol et";

            tryAgainButton.gameObject.SetActive(true);
            NextButton.gameObject.SetActive(false);
        }
        feedbackPanel.SetActive(true);  // Paneli aktif hale getir
    }

    public void TryAgain()
    {
        feedbackText.text = "";
        inputField1.text = "";
        inputField2.text = "";
        inputField3.text = "";
        tryAgainButton.gameObject.SetActive(false);
        feedbackPanel.SetActive(false);  // Paneli gizle
    }
}
