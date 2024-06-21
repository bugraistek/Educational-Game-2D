using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Act1TarifKitabıPanel : MonoBehaviour
{
    private HashSet<GameObject> uniqueDroppedObjects = new HashSet<GameObject>();
    public GameObject activatedCanvasElement;  // Aktif edilecek canvas ögesi
    public GameObject oldbackground;
    public GameObject newbackground;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Draggable"))
        {
            
            if (uniqueDroppedObjects.Add(other.gameObject))
            {
                
                if (uniqueDroppedObjects.Count == 3)
                {
                    
                    activatedCanvasElement.SetActive(true);
                    oldbackground.SetActive(false);
                    newbackground.SetActive(true) ;
                }
            }
        }
    }
}