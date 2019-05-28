using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationPadManager : MonoBehaviour
{

    public List<GameObject> triggers;
    public GameObject door;

    public int triggerCount;


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
        if (triggerCount > 0)
        {
            Debug.Log(triggerCount);
        }

        triggerCount = gameObject.GetComponent<ActivationPad>().TriggerCount;

    }


    
    
}
