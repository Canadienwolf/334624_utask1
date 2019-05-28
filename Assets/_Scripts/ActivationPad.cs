using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationPad : MonoBehaviour
{

    public bool TriggerCount;

    private Renderer color;
    private float timer = 5.0f;

    void Start()
    {
        color = GetComponentInChildren<MeshRenderer>();
        color.material.color = Color.gray;
    }

    private void OnTriggerEnter(Collider collider)
    {
        ChangeColorBlack();

        TriggerCount = true;
    }

    private void OnTriggerExit(Collider collider)
    {
        Invoke("resetTimer", timer);
    }

    //This function changes the colour back to the colour black
    private void ChangeColorBlack()
    {
        color = GetComponentInChildren<MeshRenderer>();
        color.material.color = Color.cyan;
    }

    private void resetTimer()
    {
        TriggerCount = false;

        color.material.color = Color.gray;
    }

}

