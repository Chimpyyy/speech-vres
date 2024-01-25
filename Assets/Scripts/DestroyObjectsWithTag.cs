using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectsWithTag : MonoBehaviour
{
    public string targetTag;

    private void Update()
    {
        DestroyObjects();
    }

    private void DestroyObjects()
    {
        GameObject[] objectsToDestroy = GameObject.FindGameObjectsWithTag(targetTag);

        foreach (GameObject obj in objectsToDestroy)
        {
            Destroy(obj);
        }
    }
}
