using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationPad : MonoBehaviour
{

    public List<GameObject> triggers;
    public GameObject door;

    private Renderer color;
    private int triggerCount;
    private float timeLeft = 5.0f;

    void Start()
    {
        ChangeColorBlack();
        foreach (Transform child in transform)
        {
            if (child.tag == "TriggerPad")
            {
                triggers.Add(child.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //OnTriggerEnter is called when an object enters the trigger zone
    private void OnTriggerEnter()
    {
        color = GetComponentInChildren<MeshRenderer>();
        color.material.color = Color.cyan;

        triggerCount++;

        //StartTimer();

    }

    //OnTriggerEnter is called when an object leaves the trigger zone
    private void OnTriggerExit()
    {

    }

    //This function changes the colour back to the colour black
    private void ChangeColorBlack()
    {
        color = GetComponentInChildren<MeshRenderer>();
        color.material.color = Color.black;
    }

    
    private void IEnumerator()
    {

    }

}
