using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class InteractiveObject : MonoBehaviour
{
    public GameObject interactionIndicator;
    public GameObject referenceObject;
    public InputActionProperty showButton;
    public Animator objectAnimator;
    public List<GameObject> objectsToActivate;
    public List<GameObject> objectsToDeactivate;
    public float delayTime;
    public float distanceValue;
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
        float distance = Vector3.Distance(transform.position, referenceObject.transform.position);

        if (distance < distanceValue)
        {
            ShowIndicator();

            if (!animationActivated && showButton.action.triggered)
            {
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
}
