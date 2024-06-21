using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Act11Validator : MonoBehaviour
{

    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
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
        bool isInput1Correct = inputField1.text == "1000";
        bool isInput2Correct = inputField2.text == "1";



        if (isInput1Correct && isInput2Correct)
        {
            feedbackText.text = "Tebrikler!";
            tryAgainButton.gameObject.SetActive(false);
            NextButton.gameObject.SetActive(true);
        }
        else
        {
            feedbackText.text = "Sanýrým hata yaptýk..";
            if (!isInput1Correct) feedbackText.text += " Kilogram - Ton arasýndaki birim dönüþümü kontrol et";
            if (!isInput2Correct) feedbackText.text += " Ton - Kilogram arasýndaki birim dönüþümü kontrol et";

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

    // Update is called once per frame
    void Update()
    {

    }
}
