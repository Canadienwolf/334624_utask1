using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationPad : MonoBehaviour
{


    public int TriggerCount;

    void Start()
    {
       TriggerCount = GetComponentInParent<ActivationPadManager>().triggerCount;
    }

    private void OnTriggerEnter(Collider other)
    {
        TriggerCount++;
    }

    
}
