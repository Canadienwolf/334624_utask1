using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationPadManager : MonoBehaviour
{

    public List<GameObject> triggers;
    public GameObject door;

    private Renderer color;
    public int triggerCount;


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
        if (triggerCount > 0)
        {
            Debug.Log(triggerCount);
        }
    }
    
    //This function changes the colour back to the colour black
    private void ChangeColorBlack()
    {
        color = GetComponentInChildren<MeshRenderer>();
        color.material.color = Color.black;
    }
}
