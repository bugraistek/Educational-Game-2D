using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animatorController : MonoBehaviour
{
    private Animator animator;
    public GameObject[] uiElements;
    public Button TimeMachineButton;
    void Start()
    {
        animator = GetComponent<Animator>();

        foreach (GameObject element in uiElements)
        {
            element.SetActive(false);
        }

        TimeMachineButton.interactable = true;

    }

    public void ExtendPanel()
    {
        animator.SetTrigger("ExtendTrigger");
        
    }

    public void RetractPanel()
    {
        animator.SetTrigger("RetractTrigger");
    }

    public void EnableUIElements()
    {
        foreach (GameObject element in uiElements)
        {
            element.SetActive(true);
        }

        TimeMachineButton.interactable = false;
    }

    // UI öðelerini devre dýþý býrak
    public void DisableUIElements()
    {
        foreach (GameObject element in uiElements)
        {
            element.SetActive(false);
        }

        TimeMachineButton.interactable = true;

    }




}




