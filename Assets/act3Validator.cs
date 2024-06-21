using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class act3Validator : MonoBehaviour
{
    public TMP_InputField firstInputField;
    public TMP_InputField secondInputField;
    public GameObject feedbackPanel;
    public GameObject notebookPanel;
    public GameObject nextPagePanel; // Yeni eklenen sonraki sayfa paneli
    public TextMeshProUGUI feedbackText;
    public Button nextButton;
    public Button retryButton;
    public GameObject previousPagePanel;
    void Start()
    {
        feedbackPanel.SetActive(false);
        notebookPanel.SetActive(false);
        nextPagePanel.SetActive(false); // Baþlangýçta sonraki sayfa panelini gizle
    }

    public void CheckFirstInput()
    {
        if (firstInputField.text == "1000")
        {
            feedbackText.text = "Harika, doðru cevap! Haydi not alalým.";
            nextButton.gameObject.SetActive(true);
            nextButton.onClick.RemoveAllListeners();
            nextButton.onClick.AddListener(OpenNotebook);
            retryButton.gameObject.SetActive(false);
        }
        else
        {
            feedbackText.text = "Yanlýþ girdin, tekrar dene.";
            retryButton.gameObject.SetActive(true);
            retryButton.onClick.RemoveAllListeners();
            retryButton.onClick.AddListener(TryAgainFirst);
        }
        feedbackPanel.SetActive(true);
    }

    public void OpenNotebook()
    {
        feedbackPanel.SetActive(false);
        notebookPanel.SetActive(true);
    }

    public void CheckSecondInput()
    {
        if (secondInputField.text == "1000")
        {
            feedbackText.text = "Tebrikler!";
            nextButton.gameObject.SetActive(true);
            nextButton.onClick.RemoveAllListeners();
            nextButton.onClick.AddListener(OpenNextPage); // Ýkinci input doðruysa sonraki sayfayý aç
            retryButton.gameObject.SetActive(false);
            
        }
        else
        {
            feedbackText.text = "Yanlýþ girdin, tekrar dene.";
            retryButton.gameObject.SetActive(true);
            nextButton.gameObject.SetActive(false);
            retryButton.onClick.RemoveAllListeners();
            retryButton.onClick.AddListener(TryAgainSecond);
        }
        feedbackPanel.SetActive(true);
        notebookPanel.SetActive(false); // Notebook panelini gizle
    }

    public void TryAgainFirst()
    {
        feedbackPanel.SetActive(false);
        firstInputField.text = "";
    }

    public void TryAgainSecond()
    {
        feedbackPanel.SetActive(false);
        secondInputField.text = "";
        notebookPanel.SetActive(true);
    }

    public void OpenNextPage()
    {
        feedbackPanel.SetActive(false);
        nextPagePanel.SetActive(true); // Sonraki sayfa panelini aktif et
        previousPagePanel.SetActive(false);
    }
}