using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGameObjects : MonoBehaviour
{
    public GameObject[] objectsToActivate;

    private void Start()
    {
        // Disable all objects initially
        foreach (GameObject obj in objectsToActivate)
        {
            obj.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the triggering object has the tag "Player"
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the collider.");

            // Activate all specified objects
            foreach (GameObject obj in objectsToActivate)
            {
                obj.SetActive(true);
            }
        }
    }

    // You might want to add OnTriggerExit to control deactivation behavior when the player exits the collider.
    // If you want the objectsToActivate to remain active even after the player exits the collider, you can skip implementing OnTriggerExit.
}
