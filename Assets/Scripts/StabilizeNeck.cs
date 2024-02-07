using UnityEngine;
using UnityEngine.InputSystem;

public class StabilizeNeck : MonoBehaviour
{
    public Animator animator;
    public InputActionReference activationInput;
    private bool isActivated = false;

    private void OnEnable()
    {
        activationInput.action.Enable();
        activationInput.action.started += OnActivationInput;
    }

    private void OnDisable()
    {
        activationInput.action.Disable();
        activationInput.action.started -= OnActivationInput;
    }

    private void OnActivationInput(InputAction.CallbackContext context)
    {
        // Toggle activation state for each input
        isActivated = !isActivated;

        // Log activation state
        Debug.Log("Activation Input Detected. Activation State: " + isActivated);

        // Set animator parameter based on activation state
        animator.SetBool("Activate", isActivated);
    }
}
