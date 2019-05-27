using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationPad : MonoBehaviour
{

    public List<GameObject> triggers;
    public GameObject door;

    private Renderer color;

    void Start()
    {
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
    }

    //OnTriggerEnter is called when an object leaves the trigger zone
    private void OnTriggerExit()
    {

    }

    private void ChangeColorBlack;

}
