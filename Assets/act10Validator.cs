using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshPro namespace'ini ekleyin

public class act10Validator : MonoBehaviour
{
    public TMP_InputField mantar_g;
    public TMP_InputField mantar_kg;
    public TMP_InputField tuz_mg;
    public TMP_InputField domates_mg;
    public TMP_InputField domates_kg;
    public TMP_InputField sosis_g;
    public TMP_InputField kekik_mg;
    public TMP_InputField kekik_kg;
    public TMP_InputField tavuk_mg;
    public TMP_InputField tavuk_g;
    public GameObject feedbackPanel;  // Geri bildirim i�in panel
    public TextMeshProUGUI feedbackText; // TextMeshProUGUI text component
    public Button tryAgainButton;     // Tekrar deneme butonu
    public Button NextButton;
    
    public Button kontrolEtButton;
   


    void Start()
    {
        feedbackPanel.SetActive(false);  // Ba�lang��ta paneli gizle
        kontrolEtButton.gameObject.SetActive(true);
    }

    public void CheckInputs()
    {
        bool isInput1Correct = mantar_g.text == "400";
        bool isInput2Correct = mantar_kg.text == "0,4";
        bool isInput3Correct = tuz_mg.text == "50.000";
        bool isInput4Correct = domates_kg.text == "0,5";
        bool isInput5Correct = domates_mg.text == "500.000";
        bool isInput6Correct = sosis_g.text == "800";
        bool isInput7Correct = kekik_mg.text == "170.000";
        bool isInput8Correct = kekik_kg.text == "0,17";
        bool isInput9Correct = tavuk_mg.text == "2.000.000";
        bool isInput10Correct = tavuk_g.text == "2000";

        if (isInput1Correct && isInput2Correct && isInput3Correct && isInput4Correct && isInput5Correct && isInput6Correct && isInput7Correct && isInput8Correct && isInput9Correct && isInput10Correct)
        {
            feedbackText.text = "Tebrikler!";
            tryAgainButton.gameObject.SetActive(false);
            NextButton.gameObject.SetActive(true);
        }
        else
        {
            feedbackText.text = "San�r�m hata yapt�k..";
            if (!isInput1Correct) feedbackText.text += " Mantar�n gram miktar�nda hata var, kontrol et";
            if (!isInput2Correct) feedbackText.text += " Mantar�n kilogram miktar�nda hata var, kontrol et";
            if (!isInput3Correct) feedbackText.text += " Tuzun miligram miktar�nda hata var, kontrol et";
            if (!isInput4Correct) feedbackText.text += " Domatesin kilogram miktar�nda hata var, kontrol et";
            if (!isInput5Correct) feedbackText.text += " Domatesin miligram miktar�nda hata var, kontrol et";
            if (!isInput6Correct) feedbackText.text += " Sosisin gram miktar�nda hata var, kontrol et";
            if (!isInput7Correct) feedbackText.text += " Keki�in miligram miktar�nda hata var, kontrol et";
            if (!isInput8Correct) feedbackText.text += " Keki�in kilogram miktar�nda hata var, kontrol et";
            if (!isInput9Correct) feedbackText.text += " Tavu�un miligram miktar�nda hata var, kontrol et";
            if (!isInput10Correct) feedbackText.text += " Tavu�un gram miktar�nda hata var, kontrol et";

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
