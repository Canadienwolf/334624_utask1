using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationPadManager : MonoBehaviour
{

    private float timer = 5.0f;

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
        for (int i = 0; i < triggers.Count ; i++)
        {
            if (triggers[i].GetComponent<ActivationPad>().TriggerCount)
            {
                triggerCount++;
            }
        }

        if (triggerCount == triggers.Count)
        {
            door.SetActive (false); 
            Invoke("instantiateDoor", timer);
        }

        triggerCount = 0;
    }

    private void instantiateDoor()
    {
        door.SetActive(true);
    }


    
    
}
