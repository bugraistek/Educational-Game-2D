using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Required for interacting with UI elements.
using TMPro;
public class draganddrop : MonoBehaviour
{
    Vector3 startpos;
    Camera cam;
    public string measurement;  // Measurement to display when this object collides with the target.
    public GameObject targetObject;  // The target object to detect collisions with.
    public TextMeshProUGUI textBox;  // Reference to the Text component where the measurement will be displayed.
    public TextMeshProUGUI boardBox;
    

    
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
        transform.position = startpos;  // Always return to the initial position after release.
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject == targetObject)
        {
            textBox.text = measurement;  // Update the TextMeshPro text when this object exits the trigger area of the target.
            boardBox.text = measurement;
            

            
        }   
    }
}
