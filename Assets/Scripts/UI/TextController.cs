using TMPro;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public int currentOBJ;
    public int totalOBJ;
    void Start()
    {
        UpdateText(currentOBJ, totalOBJ);
    }

    public void UpdateText(int current, int total)
    {
        if (textMeshPro != null)
        {
            textMeshPro.text = current + "/" + total;
        }
    }
}
