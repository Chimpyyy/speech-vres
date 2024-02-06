using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeckTrigger : MonoBehaviour
{
    public bool activateOnCollision = true;
    public float activationDelay = 0f;
    public GameObject collisionTarget; // Reference to the specific object to collide with
    public GameObject objectToActivate; // GameObject to activate after the delay

    private bool isActivated = false;

    private void OnCollisionEnter(Collision collision)
    {
        HandleCollision(collision.collider);
    }

    private void OnTriggerEnter(Collider other)
    {
        HandleCollision(other);
    }

    private void HandleCollision(Collider collider)
    {
        if (collider.CompareTag("Player") && !isActivated && collider.gameObject == collisionTarget)
        {
            if (activateOnCollision)
                StartCoroutine(ActivateWithDelay());
        }
    }

    private IEnumerator ActivateWithDelay()
    {
        isActivated = true;
        Debug.Log("Neck triggered!");

        yield return new WaitForSeconds(activationDelay);

        // Activate the specified GameObject after the delay
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
            Debug.Log("Activated object: " + objectToActivate.name);
        }

        isActivated = false;
        Debug.Log("Neck trigger deactivated!");
    }
}
