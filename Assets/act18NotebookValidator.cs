using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class act18notebookValidator : MonoBehaviour
{
    public TMP_InputField inputField1;
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
        bool isInput1Correct = inputField1.text == 12f.ToString("F2");



        if (isInput1Correct)
        {
            feedbackText.text = "Tebrikler!";
            tryAgainButton.gameObject.SetActive(false);
            NextButton.gameObject.SetActive(true);
        }
        else
        {
            feedbackText.text = "Sanýrým hata yaptýk..";
            if (!isInput1Correct) feedbackText.text += " 1 yýl kaç aydýr? dönüþtürücüden yardým alabilirsin.";

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
