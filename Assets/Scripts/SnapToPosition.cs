using UnityEngine;
public class SnapToPosition : MonoBehaviour
{
    public Transform[] snapPoints;
    private GameObject indicatorInstance;
    public float snapDistance = 0.1f;

    void Start()
    {
    
    }

    void Update()
    {
        foreach (Transform snapPoint in snapPoints)
        {
            float distance = Vector3.Distance(transform.position, snapPoint.position);

            if (distance < snapDistance)
            {
                SnapObject(snapPoint);
                break;
            }
        }
    }

    void SnapObject(Transform snapPoint)
    {
        transform.position = snapPoint.position;
        Renderer snapPointRenderer = snapPoint.GetComponent<Renderer>();
        if (snapPointRenderer != null)
        {
            snapPointRenderer.enabled = false;
        }
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
        }
    }
}
