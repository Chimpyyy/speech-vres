using UnityEngine;
using UnityEngine.UI;

public class ObjectiveCounter : MonoBehaviour
{
    private int objectCount = 0;
    private int previousIndicatorCount = 0;

    public TextController textController;
    public Canvas currentObjective;
    public Canvas objectiveComplete;
    public Button incrementButton;

    private void Start()
    {
        incrementButton.onClick.AddListener(IncrementObjectCount);
        UpdateText();
        UpdatePreviousIndicatorCount();
    }

    private void Update()
    {
        CheckIndicatorCountChange();
    }

    private void IncrementObjectCount()
    {
        objectCount++;
        UpdateText();
    }

    private void UpdateText()
    {
        if (textController != null)
        {
            textController.UpdateText(objectCount, 2);
        }
    }

    private void UpdatePreviousIndicatorCount()
    {
        previousIndicatorCount = CountObjectsWithTag("Indicator");
    }

    private void CheckIndicatorCountChange()
    {
        int currentIndicatorCount = CountObjectsWithTag("Indicator");

        if (currentIndicatorCount < previousIndicatorCount)
        {
            objectCount++;
            UpdateText();
        }

        if (objectCount == 2)
        {
            if (objectiveComplete != null)
            {
                objectiveComplete.gameObject.SetActive(true);
            }

            if (currentObjective != null)
            {
                currentObjective.gameObject.SetActive(false);
            }
        }

        previousIndicatorCount = currentIndicatorCount;
    }

    private int CountObjectsWithTag(string tag)
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tag);
        return objectsWithTag.Length;
    }
}
