using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationPad : MonoBehaviour
{

    public int TriggerCount;

    private Renderer color;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        ChangeColorBlack();
        TriggerCount++;
    }

    //This function changes the colour back to the colour black
    private void ChangeColorBlack()
    {
        color = GetComponentInChildren<MeshRenderer>();
        color.material.color = Color.cyan;
    }


}

