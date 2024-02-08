using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using Meta.WitAi;
using Meta.WitAi.Requests;

public class InteractiveObjectwVoice : MonoBehaviour
{
    [SerializeField] private VoiceService _voiceService;
    public GameObject interactionIndicator;
    public GameObject referenceObject;
    public InputActionProperty showButton;
    public Animator objectAnimator;
    public List<GameObject> objectsToActivate;
    public List<GameObject> objectsToDeactivate;
    public float delayTime;
    public float distanceValue;
    private bool animationActivated = false;
    private bool _isActive = false;
    private VoiceServiceRequest _request;

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
        float distance = Vector3.Distance(transform.position, referenceObject.transform.position);

        if (distance < distanceValue)
        {
            _isActive = true;
            ShowIndicator();

            if (!animationActivated && showButton.action.triggered)
            {
                Activate();
                ActivateAnimation();
                StartCoroutine(ActivateObjectsAfterDelay(delayTime, objectsToActivate));
                StartCoroutine(DeactivateObjectsAfterDelay(delayTime, objectsToDeactivate));
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

    private IEnumerator ActivateObjectsAfterDelay(float delay, List<GameObject> objects)
    {
        yield return new WaitForSeconds(delay);

        ActivateGameObjects(objects);
    }

    private IEnumerator DeactivateObjectsAfterDelay(float delay, List<GameObject> objects)
    {
        yield return new WaitForSeconds(delay);

        DeactivateGameObjects(objects);
    }

    private void ActivateGameObjects(List<GameObject> objects)
    {
        foreach (var obj in objects)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            }
        }
    }

    private void DeactivateGameObjects(List<GameObject> objects)
    {
        foreach (var obj in objects)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }
    }

    private void ActivateAnimation()
    {
        if (objectAnimator != null)
        {
            objectAnimator.SetTrigger("Activate");
            animationActivated = true;
        }
    }

    private void Activate()
    {
        _request = _voiceService.Activate(GetRequestEvents());
    }
    private VoiceServiceRequestEvents GetRequestEvents()
    {
        VoiceServiceRequestEvents events = new VoiceServiceRequestEvents();
        events.OnInit.AddListener(OnInit);
        events.OnComplete.AddListener(OnComplete);
        return events;
    }
    private void OnInit(VoiceServiceRequest request)
    {
        _isActive = true;
    }
    // Request completed
    private void OnComplete(VoiceServiceRequest request)
    {
        _isActive = false;
    }
}
