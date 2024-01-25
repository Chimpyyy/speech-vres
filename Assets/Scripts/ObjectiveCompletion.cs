using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ObjectiveCompletion : MonoBehaviour
{
    public GameObject objectiveCompleteText;
    public float spawnDistance = 2;
    public Transform head;

    private void OnDisable()
    {
        if (objectiveCompleteText != null)
        {
            objectiveCompleteText.SetActive(true);
            objectiveCompleteText.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
            Invoke("HideObjectiveCompleteText", 5f); // Hide after 2 seconds
        }
    }

    private void HideObjectiveCompleteText()
    {
        if (objectiveCompleteText != null)
        {
            objectiveCompleteText.SetActive(false);
        }
    }
}
