using UnityEngine;

public class ObjectCounter : MonoBehaviour
{
    private int objectCount = 0;
    public TextController textController; // Reference to your TextController script

    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering object is one of the objects you want to count
        if (other.CompareTag("CountableObject"))
        {
            objectCount++;
            UpdateText();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the exiting object is one of the objects you want to count
        if (other.CompareTag("CountableObject"))
        {
            objectCount--;
            UpdateText();
        }
    }

    private void UpdateText()
    {
        // Update the TextMeshPro text using your TextController
        if (textController != null)
        {
            textController.UpdateText(objectCount, 10);
        }
    }
}
