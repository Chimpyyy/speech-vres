using UnityEngine;
using UnityEngine.UI;

public class ObjectiveCounter : MonoBehaviour
{
    public int objectCount;
    private int previousIndicatorCount = 0;

    public TextController textController;
    public Canvas currentObjective;
    public Canvas objectiveComplete;
    public Button incrementButton;
    public int totalObjective;
    public string indicatorTag;

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
            textController.UpdateText(objectCount, totalObjective);
        }
    }

    private void UpdatePreviousIndicatorCount()
    {
        previousIndicatorCount = CountObjectsWithTag(indicatorTag);
    }

    private void CheckIndicatorCountChange()
    {
        int currentIndicatorCount = CountObjectsWithTag(indicatorTag);

        if (currentIndicatorCount < previousIndicatorCount)
        {
            objectCount++;
            UpdateText();
        }

        if (objectCount == totalObjective)
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
