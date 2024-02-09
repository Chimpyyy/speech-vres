using UnityEngine;
using UnityEngine.Events;

public class ButtonController : MonoBehaviour
{
    // Define a UnityEvent
    public UnityEvent onClickEvent;

    // Start is called before the first frame update
    void Start()
    {
        // Subscribe a function to the UnityEvent
        onClickEvent.AddListener(OnButtonClick);
    }

    // Function to be invoked when the button is clicked
    public void OnButtonClick()
    {
        Debug.Log("Button clicked!");
    }

    // Another function to be invoked when the button is clicked
    public void AnotherButtonClick()
    {
        Debug.Log("Another button function!");
    }
}
