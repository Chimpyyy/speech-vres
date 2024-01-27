using TMPro;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;

    void Start()
    {
        // Example: Change text on startup
        UpdateText(10, 10);
    }

    public void UpdateText(int current, int total)
    {
        if (textMeshPro != null)
        {
            textMeshPro.text = current + "/" + total;
        }
    }
}
