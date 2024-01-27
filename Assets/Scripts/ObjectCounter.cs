using Unity.VisualScripting;
using UnityEngine;

public class ObjectCounter : MonoBehaviour
{
    private int objectCount = 10;
    public TextController textController; // Reference to your TextController script
    public Canvas currentObjective;
    public Canvas objectiveComplete;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering object is one of the objects you want to count
        if (other.CompareTag("CountableObject"))
        {
            objectCount--;
            UpdateText();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the exiting object is one of the objects you want to count
        if (other.CompareTag("CountableObject"))
        {
            objectCount++;
            UpdateText();

            if(objectCount == 10)
            {
                if(objectiveComplete != null)
                {
                    objectiveComplete.gameObject.SetActive(true);
                }

                if(currentObjective != null)
                {
                    currentObjective.gameObject.SetActive(false);
                }
            }
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
