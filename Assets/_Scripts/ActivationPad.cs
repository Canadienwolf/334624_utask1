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
        //Get's the componnet called MeshRenderer in the children.
        color = GetComponentInChildren<MeshRenderer>();

        //Changes the value in the mesh renderer to the values that makes up the color gray.
        color.material.color = Color.gray;
    }

    //A command that will only rung when something other than the object collides with the trigger of the object the script is placed on.
    private void OnTriggerEnter(Collider collider)
    {
        //Runs the the command "ChangeColorBlack".
        ChangeColorBlack();

        //Sets the bool "TriggerCount" to true.
        TriggerCount = true;
    }

    //This is a command that only happens when something leaves the trigger box.
    private void OnTriggerExit(Collider collider)
    {
        //Tells the code to run the resetTimer command.
        Invoke("resetTimer", timer);
    }

    //This function changes the colour back to the colour black.
    private void ChangeColorBlack()
    {
        //Changes the value in the mesh renderer to the values that makes up the color cyan.
        color.material.color = Color.cyan;
    }

    //A command that is contained in this script only which is called resetTimer.
    private void resetTimer()
    {
        //Tells the script that it should set the "TriggerCount" bool to false.
        TriggerCount = false;

        //Changes the value in the mesh renderer to the values that makes up the color gray.
        color.material.color = Color.gray;
    }

}

