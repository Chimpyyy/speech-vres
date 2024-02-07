using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class SnapToPosition : MonoBehaviour
{
    public Transform[] snapPoints;
    public float snapDistance = 0.1f;
    public GameObject objectToActivate;
    public GameObject objectToDeactivate;
    public GameObject objectWithMeshRenderer; // Public variable for the object with a mesh renderer

    void Update()
    {
        foreach (Transform snapPoint in snapPoints)
        {
            if (Vector3.Distance(transform.position, snapPoint.position) < snapDistance)
            {
                SnapObject(snapPoint);
                DisableMeshRenderer();
                DisplayObjectiveCompletion();
                break;
            }
        }
    }

    void SnapObject(Transform snapPoint)
    {
        transform.position = snapPoint.position;
        transform.rotation = snapPoint.rotation;

        DisableGrabInteractable();
        DisableRigidbody();
    }

    void DisableMeshRenderer()
    {
        if (objectWithMeshRenderer != null)
        {
            Renderer objectRenderer = objectWithMeshRenderer.GetComponent<Renderer>();
            if (objectRenderer != null)
            {
                objectRenderer.enabled = false;
            }
        }
    }

    void DisableGrabInteractable()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        if (grabInteractable != null)
        {
            grabInteractable.enabled = false;
        }
    }

    void DisableRigidbody()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true;
        }
    }

    void DisplayObjectiveCompletion()
    {
        // Activate the UI element for objective completion
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
        }

        if (objectToDeactivate != null)
        {
            objectToDeactivate.SetActive(false);
        }
    }
}
