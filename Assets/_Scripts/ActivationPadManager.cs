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
        
        //If it find something that is a child of the gameobject that has the tag TriggerPad, put it into a list.
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
        //Loops through all the triggers and checks if each trigger is activated
        //If it is, add one to the trigger count
        for (int i = 0; i < triggers.Count ; i++)
        {
            if (triggers[i].GetComponent<ActivationPad>().TriggerCount)
            {
                //Add one 1 more to the triggerCount.
                triggerCount++;
            }
        }

        //if the triggerCount is the same as triggers.Count then run the command contained within the if statement.
        if (triggerCount == triggers.Count)
        {
            //Deactivates the gameobject that is linked to door.
            door.SetActive (false);

            //Runs the instantiateDoor command and also starts the timer.
            Invoke("instantiateDoor", timer);
        }

        //Changes the value of triggerCount back to 0.
        triggerCount = 0;
    }

    //private command that is contained within this script which is called "instantiateDoor".
    private void instantiateDoor()
    {
        //Activates the gameobject that is linked to door.
        door.SetActive(true);
    }


    
    
}
