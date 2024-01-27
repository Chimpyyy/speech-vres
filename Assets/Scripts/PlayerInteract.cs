using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteract : MonoBehaviour
{

    public InputActionProperty showButton;
    public List<Transform> npcList;
    void Update()
    {
        if (showButton.action.WasPressedThisFrame()) {
            Vector3.Distance(transform.position, npcList[0].transform.position);
            {
                Debug.Log("Nice");
            }
        }
    }
}
