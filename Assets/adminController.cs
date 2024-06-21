using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adminController : MonoBehaviour
{
    public GameObject[] pages; // Sayfalarýnýzý içeren GameObjects arrayi
    public Button nextButton;
    public Button previousButton;

    private int currentPageIndex = 0;

    void Start()
    {
        // Ýlk sayfayý göstermek için
        ShowPage(currentPageIndex);

        // Buton click eventlerini ayarlama
        nextButton.onClick.AddListener(ShowNextPage);
        previousButton.onClick.AddListener(ShowPreviousPage);

        // Baþlangýçta Previous butonunu devre dýþý býrak
        previousButton.interactable = false;
    }

    void ShowPage(int pageIndex)
    {
        // Tüm sayfalarý kapat
        foreach (GameObject page in pages)
        {
            page.SetActive(false);
        }

        // Ýlgili sayfayý aç
        pages[pageIndex].SetActive(true);
    }

    void ShowNextPage()
    {
        if (currentPageIndex < pages.Length - 1)
        {
            currentPageIndex++;
            ShowPage(currentPageIndex);
        }

        // Butonlarýn durumunu güncelle
        UpdateButtonInteractable();
    }

    void ShowPreviousPage()
    {
        if (currentPageIndex > 0)
        {
            currentPageIndex--;
            ShowPage(currentPageIndex);
        }

        // Butonlarýn durumunu güncelle
        UpdateButtonInteractable();
    }

    void UpdateButtonInteractable()
    {
        nextButton.interactable = currentPageIndex < pages.Length - 1;
        previousButton.interactable = currentPageIndex > 0;
    }
}
