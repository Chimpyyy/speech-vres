using Meta.WitAi.CallbackHandlers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class noChoice : MonoBehaviour
{
    public MultiValueEvent onChoice = new MultiValueEvent();

    public void onNo(string[] values)
    {
        if (gameObject.activeSelf && values[0] == "no")
        {
            onChoice.Invoke(values);
        }

        else
            print("Not Working");
    }
}
