using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
    [Header("Panels")]
    public List<GameObject> panels;

    private int currentIndex = 0;

    public void OnNext()
    {
        if (gameObject.activeSelf && currentIndex < panels.Count - 1)
        {
            panels[currentIndex].SetActive(false);
            currentIndex++;
            panels[currentIndex].SetActive(true);
        }
        else
        {
            Debug.LogWarning("Already at the last panel.");
        }
    }

    public void OnPrev()
    {
        if (gameObject.activeSelf && currentIndex > 0)
        {
            panels[currentIndex].SetActive(false);
            currentIndex--;
            panels[currentIndex].SetActive(true);
        }
        else
        {
            Debug.LogWarning("Already at the first panel.");
        }
    }
}
