using UnityEngine;
using UnityEngine.UI;

public class ObjectDestroyer : MonoBehaviour
{
    public string objectTag = "OBJ1"; // Tag of the objects to be destroyed

    private void Start()
    {
        // Try to find the Button component on the GameObject or its children
        Button destroyButton = GetComponentInChildren<Button>();

        // Check if the Button component is found
        if (destroyButton != null)
        {
            // Attach a listener to the button's click event
            destroyButton.onClick.AddListener(DestroyObjectsWithTag);
        }
    }

    private void DestroyObjectsWithTag()
    {
        // Find all game objects with the specified tag
        GameObject[] objectsToDestroy = GameObject.FindGameObjectsWithTag(objectTag);

        // Destroy each object in the array
        foreach (GameObject obj in objectsToDestroy)
        {
            Destroy(obj);
        }
    }
}
