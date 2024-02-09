using Oculus.VoiceSDK.UX;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PushToTalk : MonoBehaviour
{
    public ActivationVoiceButton ActivationVoiceButton;

    public void OnAButton(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            ClickButton();
        }
    }

    private void ClickButton()
    {
        // Check if the button has any listeners
        if (ActivationVoiceButton != null)
        {
            // Invoke the OnClick method of the ActivationVoiceButton
            ActivationVoiceButton.OnClick();
        }
        else
        {
            Debug.LogWarning("ActivationVoiceButton reference is null.");
        }
    }
}
