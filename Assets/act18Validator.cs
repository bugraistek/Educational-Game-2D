using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class act18Valdiator : MonoBehaviour
{
    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
    public TMP_InputField inputField3;
    public TMP_InputField inputField4;
    public GameObject feedbackPanel;  // Geri bildirim için panel
    public TextMeshProUGUI feedbackText; // TextMeshProUGUI text component
    public Button tryAgainButton;
    public Button kontrolEtButton;
    public Button NextButton;



    // Start is called before the first frame update
    void Start()
    {
        feedbackPanel.SetActive(false);
    }

    public void CheckInputs()
    {
        bool isInput1Correct = inputField1.text == 2f.ToString("F2");
        bool isInput2Correct = inputField2.text == 48f.ToString("F2");
        bool isInput3Correct = inputField3.text == 1f.ToString("F2");
        bool isInput4Correct = inputField4.text == 60f.ToString("F2");


        if (isInput1Correct && isInput2Correct && isInput3Correct && isInput4Correct)
        {
            feedbackText.text = "Tebrikler!";
            tryAgainButton.gameObject.SetActive(false);
            NextButton.gameObject.SetActive(true);
        }
        else
        {
            feedbackText.text = "Sanýrým hata yaptýk..";
            if (!isInput1Correct) feedbackText.text += " garson 1'in yýl cinsinden sözleþme süresinde hata var, kontrol et";
            if (!isInput2Correct) feedbackText.text += " garson 2'nin ay cinsinden sözleþme süresinde hata var, kontrol et";
            if (!isInput3Correct) feedbackText.text += " muhasebeci'nin yýl cinsinden sözleþme süresinde hata var, kontrol et";
            if (!isInput4Correct) feedbackText.text += " þoförler'in ay cinsinden sözleþme süresinde hata var, kontrol et";

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
}
