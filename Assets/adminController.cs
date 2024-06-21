using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adminController : MonoBehaviour
{
    public GameObject[] pages; // Sayfalar�n�z� i�eren GameObjects arrayi
    public Button nextButton;
    public Button previousButton;

    private int currentPageIndex = 0;

    void Start()
    {
        // �lk sayfay� g�stermek i�in
        ShowPage(currentPageIndex);

        // Buton click eventlerini ayarlama
        nextButton.onClick.AddListener(ShowNextPage);
        previousButton.onClick.AddListener(ShowPreviousPage);

        // Ba�lang��ta Previous butonunu devre d��� b�rak
        previousButton.interactable = false;
    }

    void ShowPage(int pageIndex)
    {
        // T�m sayfalar� kapat
        foreach (GameObject page in pages)
        {
            page.SetActive(false);
        }

        // �lgili sayfay� a�
        pages[pageIndex].SetActive(true);
    }

    void ShowNextPage()
    {
        if (currentPageIndex < pages.Length - 1)
        {
            currentPageIndex++;
            ShowPage(currentPageIndex);
        }

        // Butonlar�n durumunu g�ncelle
        UpdateButtonInteractable();
    }

    void ShowPreviousPage()
    {
        if (currentPageIndex > 0)
        {
            currentPageIndex--;
            ShowPage(currentPageIndex);
        }

        // Butonlar�n durumunu g�ncelle
        UpdateButtonInteractable();
    }

    void UpdateButtonInteractable()
    {
        nextButton.interactable = currentPageIndex < pages.Length - 1;
        previousButton.interactable = currentPageIndex > 0;
    }
}
