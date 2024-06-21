using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Required for interacting with UI elements.
using TMPro;

public class dragAndDrop2 : MonoBehaviour
{
    private Camera cam;
    private Vector3 startpos;
    public TextMeshProUGUI kilogramText;
    public TextMeshProUGUI gramText;

    private bool isOverKilogramMeter = false;
    private bool isOverGramMeter = false;

    void Start()
    {
        cam = Camera.main;
        startpos = this.transform.position;
    }

    private void OnMouseDrag()
    {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.WorldToScreenPoint(transform.position).z);
        Vector3 objPosition = cam.ScreenToWorldPoint(mousePos);
        transform.position = new Vector3(objPosition.x, objPosition.y, 0);
    }

    private void OnMouseUp()
    {
        if (isOverKilogramMeter)
        {
            kilogramText.text = "1";
        }
        else if (isOverGramMeter)
        {
            gramText.text = "1000";
        }

        transform.position = startpos;  // Always return to initial position after release.
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "kgOlcer")
        {
            isOverKilogramMeter = true;
        }
        else if (other.gameObject.name == "gOlcer")
        {
            isOverGramMeter = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "kgOlcer")
        {
            isOverKilogramMeter = false;
        }
        else if (other.gameObject.name == "gOlcer")
        {
            isOverGramMeter = false;
        }
    }
}