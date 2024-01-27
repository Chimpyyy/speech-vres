using UnityEngine;
using UnityEngine.InputSystem;

public class InteractiveObject : MonoBehaviour
{
    public GameObject interactionIndicator;
    public InputActionProperty showButton;
    public Animator objectAnimator;

    private bool animationActivated = false;

    private void Start()
    {
        HideIndicator();
    }

    private void Update()
    {
        CheckDistance();
    }

    private void CheckDistance()
    {
        float distance = Vector3.Distance(transform.position, Camera.main.transform.position);

        if (distance < 2.0f)  // Adjust the distance based on your preference
        {
            ShowIndicator();

            if (!animationActivated && showButton.action.WasPressedThisFrame())
            {
                ActivateAnimation();
            }
        }
        else
        {
            HideIndicator();
        }
    }

    private void ShowIndicator()
    {
        interactionIndicator.SetActive(true);
    }

    private void HideIndicator()
    {
        interactionIndicator.SetActive(false);
    }

    private void PositionIndicatorAtChest(Vector3 chestPosition)
    {
        // Convert chest position to screen space
        Vector3 screenPos = Camera.main.WorldToScreenPoint(chestPosition);

        // Set the UI position
        interactionIndicator.transform.position = screenPos;
    }

    private void ActivateAnimation()
    {
        if (objectAnimator != null)
        {
            objectAnimator.SetTrigger("Activate");  // Assuming you have an "Activate" trigger in your animator
            animationActivated = true;
        }
    }
}
