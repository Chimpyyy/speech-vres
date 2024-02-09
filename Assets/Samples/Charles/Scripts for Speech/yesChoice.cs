using Meta.WitAi.CallbackHandlers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class yesChoice : MonoBehaviour
{
    public MultiValueEvent onChoice = new MultiValueEvent();

    public void onYes(string[] values)
    {
        if (gameObject.activeSelf && values[0] == "yes")
        {
            onChoice.Invoke(values);
        }
        
        else
            print("Not Working"); 
    }
}
