using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshPro namespace'ini ekleyin

public class act6Validator : MonoBehaviour
{
    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
    public TMP_InputField inputField3;
    public TMP_InputField inputField4;
    public TMP_InputField inputField5;
    public TMP_InputField inputField6;
    public GameObject feedbackPanel;  // Geri bildirim için panel
    public TextMeshProUGUI feedbackText; // TextMeshProUGUI text component
    public Button tryAgainButton;     // Tekrar deneme butonu
    public Button NextButton;
    public Button kaydetButton;
    public Button kontrolEtButton;
    public TextMeshProUGUI textBox1;
    public TextMeshProUGUI textBox2;  // Reference to the Text component where the measurement will be displayed.
    public TextMeshProUGUI textBox3;// Reference to the Text component where the measurement will be displayed.
    public TextMeshProUGUI boardBox;


    void Start()
    {
        feedbackPanel.SetActive(false);  // Baþlangýçta paneli gizle
        kontrolEtButton.gameObject.SetActive(false);
    }

    public void CheckInputs()
    {
        bool isInput1Correct = inputField1.text == "300";
        bool isInput2Correct = inputField2.text == "100";
        bool isInput3Correct = inputField3.text == "600";
        bool isInput4Correct = inputField4.text == "900";
        bool isInput5Correct = inputField5.text == "150";
        bool isInput6Correct = inputField6.text == "1500";


        if (isInput1Correct && isInput2Correct && isInput3Correct && isInput4Correct && isInput5Correct && isInput6Correct)
        {
            feedbackText.text = "Tebrikler!";
            tryAgainButton.gameObject.SetActive(false);
            NextButton.gameObject.SetActive(true);
        }
        else
        {
            feedbackText.text = "Sanýrým hata yaptýk..";
            if (!isInput1Correct) feedbackText.text += " zeytin miktarýný kontrol et";
            if (!isInput2Correct) feedbackText.text += " baharat miktarýný kontrol et";
            if (!isInput3Correct) feedbackText.text += " biber miktarýný kontrol et";
            if (!isInput4Correct) feedbackText.text += "peynir miktarýný kontrol et";
            if (!isInput5Correct) feedbackText.text += "sos miktarýný kontrol et";
            if (!isInput6Correct) feedbackText.text += "sucuk miktarýný kontrol et";
            tryAgainButton.gameObject.SetActive(true);
            NextButton.gameObject.SetActive(false);
        }
        feedbackPanel.SetActive(true);  // Paneli aktif hale getir
    }

    public void TryAgain()
    {

        tryAgainButton.gameObject.SetActive(false);
        feedbackPanel.SetActive(false);  // Paneli gizle
    }


    public void kaydet()
    {


        feedbackPanel.SetActive(false);
        feedbackText.text = "";
        textBox1.text = "";
        textBox2.text = "";
        textBox3.text = "";
        boardBox.text = "";
        kontrolEtButton.gameObject.SetActive(true);
        kaydetButton.gameObject.SetActive(false);
        // Paneli gizle

    }
}
