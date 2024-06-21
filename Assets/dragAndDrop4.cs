using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Required for interacting with UI elements.
using TMPro;

public class dragAndDrop4 : MonoBehaviour
{
    private Camera cam;
    private Vector3 startpos;
    public TextMeshProUGUI kilogramText;
    public TextMeshProUGUI tonText;

    private bool isOverKilogramMeter = false;
    private bool isOverTonMeter = false;

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
            kilogramText.text = "1000";
        }
        else if (isOverTonMeter)
        {
            tonText.text = "1";
        }

        transform.position = startpos;  // Always return to initial position after release.
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "KgOlcerBig")
        {
            isOverKilogramMeter = true;
        }
        else if (other.gameObject.name == "tonOlcer")
        {
            isOverTonMeter = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "KgOlcerBig")
        {
            isOverKilogramMeter = false;
        }
        else if (other.gameObject.name == "tonOlcer")
        {
            isOverTonMeter = false;
        }
    }
}
